using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        #region Instance Attributes
        private SqlConnection con;   // DB Connection
        DataSet ds;                 //Declare the DataSet object
        SqlDataAdapter da;          //Declare the DataAdapter object
        int totUsers;
        SqlCommandBuilder cb;
        #endregion
        #region Static Attributes
        private static IDataLayer dataLayerSingletonInstance;  // DataLayer object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the DataLayer singleton creation. ie in GetInstance () method
        #endregion
        #region Constructors
        public static IDataLayer GetInstance() // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }
        private DataLayer()  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            openConnection();
        }
        #endregion
        public void openConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=MY-V-U-ITSQL05.tusstudent.ad.tus.ie\\INSTBL07,60157 ;Initial Catalog=Git-IT-Donedb;User id =K00209278; Password=$QLT3AM07;";
           //con.ConnectionString = "Data Source=gititdone2.database.windows.net;Initial Catalog=Git-IT-Donedb;User ID=gititdoneadmin; Password=GitITDone23!";

            // old string Data Source=gititdone2.database.windows.net;Initial Catalog=Git-IT-Donedb;User ID=gititdoneadmin; Password=GitITDone23!;
            // //
            try
            {
                con.Open();
                //MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                Debug.WriteLine(excep.StackTrace);
                Environment.Exit(0); //Force the application to close
            }
        }

        public void closeConnection()
        {
            con.Close();
        }

        public SqlConnection getConnection()
        {
            return con;
        }

        public List<IUser> getAllUsers()
        {
            List<IUser> UserList = new List<IUser>();
            try
            {
                //username, password, isManager, userID, salary, department, phoneNumber, position, startDate
                ds = new DataSet();
                string sql = "SELECT username, password, isManager, UserID, salary, department, phoneNumber, position, startDate FROM Users";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                totUsers = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];
                    IUser user = UserFactory.GetUser(dRow.ItemArray.GetValue(0).ToString(),  // Using a Factory to create the user entity object. ie seperating object creation from business logic
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        Convert.ToBoolean(Convert.ToInt16(dRow.ItemArray.GetValue(2))),
                                                       Convert.ToInt16(dRow.ItemArray.GetValue(3)),
                                                       Convert.ToDouble(dRow.ItemArray.GetValue(4).ToString()),
                                                       dRow.ItemArray.GetValue(5).ToString(),
                                                       dRow.ItemArray.GetValue(6).ToString(),
                                                       dRow.ItemArray.GetValue(7).ToString(),
                                                       Convert.ToDateTime(dRow.ItemArray.GetValue(8).ToString()));
                    //Debug.WriteLine(dRow.ItemArray.GetValue(8));
                    user.PrintUserDetails();
                    UserList.Add(user);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "GetAllUsers");
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return UserList;
        }
        public void addNewUserToDB(IUser theUser)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                totUsers = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = theUser.Username;
                dRow[1] = theUser.Password;
                dRow[2] = theUser.StartDate;
                dRow[3] = theUser.Salary;
                dRow[4] = theUser.Department;
                dRow[5] = theUser.PhoneNumber;
                dRow[6] = theUser.Position;
                dRow[8] = theUser.IsManager;

                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
                ds = new DataSet();
                da.Fill(ds, "UsersData");
                theUser.UserID = Convert.ToInt32(ds.Tables["UsersData"].Rows[totUsers].ItemArray.GetValue(7).ToString());
                theUser.PrintUserDetails();
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                MessageBox.Show(excep.Message);
                //Application.Exit();
                Environment.Exit(1); //Force the application to close
            }
        }
        public bool deleteUserFromDB(BusinessEntities.IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Environment.Exit(1);
            }
            return true;
        }


        public bool editUserInDB(IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow[0] = user.Username;
                    findRow[1] = user.Password;
                    findRow[2] = user.StartDate;
                    findRow[3] = user.Salary;
                    findRow[4] = user.Department;
                    findRow[5] = user.PhoneNumber;
                    findRow[6] = user.Position;
                    findRow[8] = user.IsManager;

                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Environment.Exit(1);
            }
            return true;
        }


        public List<IOrder> getAllOrders()
        {
            List<IOrder> OrderList = new List<IOrder>();
            List<IProductLine> ProductLineList = new List<IProductLine>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Orders";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "OrdersData");
                int totNumOrders = ds.Tables["OrdersData"].Rows.Count;
                for (int i = 0; i < totNumOrders; i++)
                {
                    DataRow dRow = ds.Tables["OrdersData"].Rows[i];

                    IOrder order = OrderFactory.GetOrder(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()),
                                            Convert.ToBoolean(dRow.ItemArray.GetValue(3).ToString()),
                                            DateTime.Parse(dRow.ItemArray.GetValue(4).ToString()));
                    OrderList.Add(order);


                }
            }

            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return OrderList;
        }

        public List<IProductLine> getProductLinesForOrder(int OrderCode)
        {
            List<IProductLine> ProductLineList = new List<IProductLine>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From ProductLines  where OrderCode = " + OrderCode.ToString();
                // We only want the product lines for this order, so thats all we will select into our DataSet
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ProductLinesData");
                int totNumLines = ds.Tables["ProductLinesData"].Rows.Count;
                for (int i = 0; i < totNumLines; i++)
                {
                    DataRow dRow = ds.Tables["ProductLinesData"].Rows[i];
                    IProductLine productLine = ProductLineFactory.GetProductLine(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()),
                                            dRow.ItemArray.GetValue(2).ToString(),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(3).ToString()),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()),
                                            Convert.ToBoolean(dRow.ItemArray.GetValue(5).ToString()));
                    ProductLineList.Add(productLine);

                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }

            return ProductLineList;
        }

        public bool editProductLineInDB(IProductLine productLine)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From ProductLines";
                da = new SqlDataAdapter(sql, getConnection());
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ProductLinesData");
                object[] compK = new object[2] { productLine.ProductLineCode.ToString(), productLine.OrderCode }; // using a composite primiary key
                DataRow findRow = ds.Tables["ProductLinesData"].Rows.Find(compK);
                if (findRow != null)
                {
                    findRow[4] = productLine.QtyPrepared.ToString();
                    findRow[5] = productLine.Complete;

                }
                da.Update(ds, "ProductLinesData"); //update row in database table
                return true;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().State.ToString() == "Open")
                    getConnection().Close();
                Application.Exit();
                return false;
            }
        }//end of functoion

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------

        public bool editReservationInDB(IReservation reservation)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Reservation";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ReservationData");
                DataRow findRow = ds.Tables["ReservationData"].Rows.Find(reservation.BookingNumber);
                //Debug.WriteLine(findRow == null);
                if (findRow != null)
                {
                    //findRow["bookingNo"] = reservation.BookingNumber;
                    findRow["date"] = reservation.Date;
                    findRow["time"] = reservation.Time;
                    findRow["creditCardNumber"] = reservation.CreditCardNumber;
                    findRow["bill"] = reservation.Bill;
                    findRow["checkedIn"] = reservation.CheckedIn;
                    findRow["personID"] = reservation.Person.PersonID;

                }
                da.Update(ds, "ReservationData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "editReservation");
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Environment.Exit(1);
            }
            return true;
        }

        public bool editRoomResvInDB(IRoomReservation roomResv)
        {
            editReservationInDB(roomResv);
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From RoomResv";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomResvData");
                DataRow findRow = ds.Tables["RoomResvData"].Rows.Find(roomResv.RoomReservationID);
                //Debug.WriteLine(findRow == null);

                if (findRow != null)
                {
                    //findRow["roomResvId"] = roomResv.RoomReservationID;
                    findRow["checkOutDate"] = roomResv.CheckOutDate;
                    findRow["roomID"] = roomResv.Room.RoomID;
                    //findRow["mainBookingNo"] = roomResv.MainBookingNumber;
                    findRow["keyReturned"] = roomResv.KeyReturned;
                    findRow["isLateCheckout"] = roomResv.IsLateCheckout;

                }
                da.Update(ds, "RoomResvData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "editRoomResv");
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Environment.Exit(1);
            }
            return true;
        }

        public List<IRoomReservation> GetAllRoomReservations()
        {
            List<IRoomReservation> RoomReservationList = new List<IRoomReservation>();
            try
            {
                //username, password, isManager, userID, salary, department, phoneNumber, position, startDate
                ds = new DataSet();
                string sql = "select * from Reservation r INNER JOIN [dbo].[RoomResv] rr on r.bookingNo = rr.mainBookingNo;";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomResvData");
                //Debug.WriteLine(ds.Tables["RoomResvData"].Rows.Count);

                foreach (DataRow dRow in ds.Tables["RoomResvData"].Rows)
                {
                    IRoomReservation roomReservation = RoomReservationFactory.GetRoomReservation((int)dRow["bookingNo"],
                        Convert.ToDateTime(dRow["date"]).Date,
                        (TimeSpan)dRow["time"],
                        dRow["creditCardNumber"].ToString(),
                        Convert.ToDouble(dRow["bill"]),
                        (bool)dRow["checkedIn"],
                        FindPersonInDB((int)dRow["personID"]),
                        (int)dRow["roomResvID"],
                        Convert.ToDateTime(dRow["checkOutDate"]).Date,
                        getRoomByID((int)dRow["roomID"]),
                        (bool)dRow["keyReturned"],
                        (int)dRow["mainBookingNo"],
                        (bool)dRow["isLateCheckout"]);

                    //Debug.WriteLine(dRow.ItemArray.GetValue(8));
                    roomReservation.PrintRoomResvDetails();
                    RoomReservationList.Add(roomReservation);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "GetAllRoomResv");
                Debug.WriteLine(excep);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return RoomReservationList;
        }


        public int addNewPersonToDB(IPerson theperson)
        {
            int PersonID = -1;
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Person";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "PersonData");
                totUsers = ds.Tables["PersonData"].Rows.Count;
                DataRow dRow = ds.Tables["PersonData"].NewRow();
                dRow[1] = theperson.FirstName;
                dRow[2] = theperson.LastName;
                dRow[3] = theperson.PhoneNumber;
                dRow[4] = theperson.Email;


                ds.Tables["PersonData"].Rows.Add(dRow);
                da.Update(ds, "PersonData");
                ds = new DataSet();
                da.Fill(ds, "PersonData");
                theperson.PersonID = Convert.ToInt32(ds.Tables["PersonData"].Rows[totUsers].ItemArray.GetValue(0).ToString());
                PersonID = theperson.PersonID;
                theperson.PrintPersonDetails();

            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                MessageBox.Show(excep.Message);
                //Application.Exit();
                Environment.Exit(1); //Force the application to close
            }
            return PersonID;
        }// end of function

        public List<IPerson> getAllPeople()
        {
            List<IPerson> People = new List<IPerson>();
            try
            {
                //
                ds = new DataSet();
                string sql = "SELECT * FROM Person";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "PeopleData");

                foreach (DataRow dRow in ds.Tables["PeopleData"].Rows)
                {

                    IPerson person = PersonFactory.GetPerson(
                        (int)dRow["personID"],  // Using a Factory to create the user entity object. ie seperating object creation from business logic
                        dRow["firstName"].ToString(),
                        dRow["lastName"].ToString(),
                        dRow["phoneNumber"].ToString(),
                        dRow["email"].ToString());

                    //Debug.WriteLine(dRow.ItemArray.GetValue(8));
                    person.PrintPersonDetails();
                    People.Add(person);
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "GetAllPeople");
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return People;
        }

        public List<IRoom> getRooms()
        {
            List<IRoom> Rooms = new List<IRoom>();
            try
            {
                //
                ds = new DataSet();
                string sql = "SELECT * FROM Room";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomData");

                foreach (DataRow dRow in ds.Tables["RoomData"].Rows)
                {

                    IRoom room = RoomFactory.GetRoom(
                        (int)dRow["roomID"],
                        (int)dRow["roomNo"],
                        dRow["roomType"].ToString(),
                        (int)dRow["occupancy"],
                        Convert.ToDouble(dRow["baseRate"]),
                        new List<IKey>());

                    //Debug.WriteLine(dRow.ItemArray.GetValue(8));
                    Rooms.Add(room);
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "GetRooms");
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return Rooms;
        }
        public bool deletePersonFromDB(BusinessEntities.IPerson person)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Person";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "PeopleData");
                DataRow findRow = ds.Tables["PeopleData"].Rows.Find(person.PersonID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "PeopleData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Environment.Exit(1);
            }
            return true;
        }
        public Person FindPersonInDB(int Id)
        {
            Person foundPerson = null;

            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM Person";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "PeopleData");
                DataRow findRow = ds.Tables["PeopleData"].Rows.Find(Id);

                if (findRow != null)
                {
                    // You should create a Person instance here based on the data in the DataRow
                    foundPerson = new Person
                    {
                        // Assign properties based on the data in the DataRow
                        PersonID = (int)findRow["PersonID"],
                        FirstName = findRow["FirstName"].ToString(),
                        LastName = findRow["LastName"].ToString(),
                        PhoneNumber = findRow["PhoneNumber"].ToString(),
                        Email = findRow["email"].ToString()
                        // Add more properties as needed
                    };
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "FindPersonInDB");
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Environment.Exit(1);
            }

            return foundPerson;
        }

        public Room getRoomByID(int roomID)
        {
            Room foundRoom = null;

            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM Room";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "RoomData");
                DataRow findRow = ds.Tables["RoomData"].Rows.Find(roomID);

                if (findRow != null)
                {
                    // You should create a Person instance here based on the data in the DataRow
                    foundRoom = new Room
                    {
                        RoomID = (int)findRow["roomID"],
                        RoomNumber = (int)findRow["roomNo"],
                        RoomType = findRow["roomType"].ToString(),
                        Occupancy = (int)findRow["occupancy"],
                        BaseRate = Convert.ToDouble(findRow["baseRate"]),

                        //RoomResvID = (int)findRow["roomResvID"],
                        Keys = new List<IKey>()
                    };

                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Environment.Exit(1);
            }

            return foundRoom;
        }

        public void addNewGuestToDB(IGuest theGuest)
        {
            try
            {
                //addNewPersonToDB(theperson);
                DataSet ds = new DataSet();
                string sql = "SELECT * From Guest";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GuestData");
                totUsers = ds.Tables["GuestData"].Rows.Count;
                DataRow dRow = ds.Tables["GuestData"].NewRow();
                //dRow[0] = theGuest.FirstName;
                //dRow[1] = theGuest.LastName;
                //dRow[2] = theGuest.PhoneNumber;
                //dRow[3] = personID;
                dRow[2] = theGuest.Address;
                dRow[1] = theGuest.DateOfBirth;
                dRow[3] = theGuest.PersonGuestID;
                //theGuest.PersonGuestID = personID;


                ds.Tables["GuestData"].Rows.Add(dRow);
                da.Update(ds, "GuestData");
                ds = new DataSet();
                da.Fill(ds, "GuestData");
                // theUser.UserID = Convert.ToInt32(ds.Tables["UsersData"].Rows[totUsers].ItemArray.GetValue(7).ToString());
                // theUser.PrintUserDetails();
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                MessageBox.Show(excep.Message);
                //Application.Exit();
                Environment.Exit(1); //Force the application to close
            }
        }

        public void addReservationToDB(IReservation reservation)
        {
            try
            {
                //MessageBox.Show(reservation.Person.PersonID.ToString());
                DataSet ds = new DataSet();
                string sql = "SELECT * From Reservation";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ReservationData");
                totUsers = ds.Tables["ReservationData"].Rows.Count;
                DataRow dRow = ds.Tables["ReservationData"].NewRow();
                dRow["date"] = reservation.Date.Date;
                dRow["time"] = reservation.Time;
                dRow["creditCardNumber"] = reservation.CreditCardNumber;
                dRow["bill"] = reservation.Bill;
                dRow["checkedIn"] = reservation.CheckedIn;
                dRow["personID"] = reservation.Person.PersonID;


                ds.Tables["ReservationData"].Rows.Add(dRow);
                da.Update(ds, "ReservationData");
                ds = new DataSet();
                da.Fill(ds, "ReservationData");
                reservation.BookingNumber = (int)ds.Tables["ReservationData"].Rows[totUsers]["bookingNo"];
                //PersonID = theperson.PersonID;
                //theperson.PrintUserDetails();
            }
            catch (Exception ex)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                MessageBox.Show(ex.Message, "addReservation");
                //Application.Exit();
                Environment.Exit(1); //Force the application to close
            }

        }
        public void addNewRoomReservationToDB(IRoomReservation theRoomreservation)
        {

            try
            {
                addReservationToDB(theRoomreservation);
                theRoomreservation.MainBookingNumber = theRoomreservation.BookingNumber;
                //MessageBox.Show(theRoomreservation.MainBookingNumber.ToString());
                DataSet ds = new DataSet();
                string sql = "SELECT * From RoomResv";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomResvData");
                totUsers = ds.Tables["RoomResvData"].Rows.Count;
                DataRow dRow = ds.Tables["RoomResvData"].NewRow();
                dRow["CheckOutDate"] = theRoomreservation.CheckOutDate.Date;
                dRow["roomID"] = theRoomreservation.Room.RoomID;
                dRow["keyReturned"] = theRoomreservation.KeyReturned;
                dRow["mainBookingNo"] = theRoomreservation.MainBookingNumber;
                dRow["isLateCheckout"] = theRoomreservation.IsLateCheckout;
                // dRow2[5] = theRoomreservation.RoomReservationID;


                ds.Tables["RoomResvData"].Rows.Add(dRow);
                da.Update(ds, "RoomResvData");
                ds = new DataSet();
                da.Fill(ds, "RoomResvData");
                theRoomreservation.RoomReservationID = (int)ds.Tables["RoomResvData"].Rows[totUsers]["roomResvID"];


            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                MessageBox.Show(excep.Message, "addRoomReservation");
                //Application.Exit();
                Environment.Exit(1); //Force the application to close
            }
            //return PersonID;
        }


        // end of function

        public void addNewRoomToDB(IRoom theRoom)
        {

            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Room";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomData");
                totUsers = ds.Tables["RoomData"].Rows.Count;
                DataRow dRow = ds.Tables["RoomData"].NewRow();
                dRow[1] = theRoom.RoomType;
                dRow[2] = theRoom.Occupancy;
                dRow[3] = theRoom.RoomNumber;
                dRow[4] = theRoom.BaseRate;


                ds.Tables["RoomData"].Rows.Add(dRow);
                da.Update(ds, "RoomData");
                ds = new DataSet();
                da.Fill(ds, "RoomData");
                theRoom.RoomID = Convert.ToInt32(ds.Tables["RoomData"].Rows[totUsers].ItemArray.GetValue(0).ToString());


            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                MessageBox.Show(excep.Message);
                //Application.Exit();
                Environment.Exit(1); //Force the application to close
            }

        }// end of function
        public bool deleteRoomReservationFromDB(BusinessEntities.IRoomReservation theRoomResv)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From RoomResv";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ResvData");
                DataRow findRow = ds.Tables["ResvData"].Rows.Find(theRoomResv.BookingNumber);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "ResvData"); //remove row from database table

                ds = new DataSet();
                string sql1 = "SELECT * From Reservation";
                da = new SqlDataAdapter(sql1, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "Resv1Data");
                DataRow findRow1 = ds.Tables["Resv1Data"].Rows.Find(theRoomResv.BookingNumber);
                if (findRow != null)
                {
                    findRow1.Delete(); //mark row as deleted
                }
                da.Update(ds, "Resv1Data"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Environment.Exit(1);
            }
            return true;
        }//end of function

        public int addNewVoucherToDB(IVoucher thevoucher)
        {
            int VoucherID = -1;
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Voucher";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "VoucherData");
                totUsers = ds.Tables["VoucherData"].Rows.Count;
                DataRow dRow = ds.Tables["VoucherData"].NewRow();
                dRow[1] = thevoucher.Amount;
                dRow[2] = thevoucher.Name;
                dRow[3] = thevoucher.Type;
                dRow[4] = thevoucher.Message;


                ds.Tables["VoucherData"].Rows.Add(dRow);
                da.Update(ds, "VoucherData");
                ds = new DataSet();
                da.Fill(ds, "VoucherData");
                thevoucher.VoucherID = Convert.ToInt32(ds.Tables["VoucherData"].Rows[totUsers].ItemArray.GetValue(0).ToString());
                VoucherID = thevoucher.VoucherID;
                thevoucher.GetVoucher();

            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                MessageBox.Show(excep.Message);
                //Application.Exit();
                Environment.Exit(1); //Force the application to close
            }
            return VoucherID;
        }// end of function


        public List<IVoucher> getAllVouchers()
        {
            List<IVoucher> vouchers = new List<IVoucher>();
            try
            {
                //
                ds = new DataSet();
                string sql = "SELECT * FROM Voucher";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "VoucherData");

                foreach (DataRow dRow in ds.Tables["VoucherData"].Rows)
                {

                    IVoucher voucher = VoucherFactory.GetVoucher(
                        (int)dRow["voucherID"],  // Using a Factory to create the user entity object. ie seperating object creation from business logic
                        (double)dRow["amount"],
                        dRow["name"].ToString(),
                        dRow["type"].ToString(),
                        dRow["message"].ToString());


                    Debug.WriteLine(dRow.ItemArray.GetValue(1));
                    voucher.PrintVoucherDetails();
                    vouchers.Add(voucher);
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message, "GetAllVouchers");
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return vouchers;
        }//end of function

        public void addNewPaymentToDB(IPayment thePayment)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Payment";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "PaymentData");
                totUsers = ds.Tables["PaymentData"].Rows.Count;
                DataRow dRow = ds.Tables["PaymentData"].NewRow();
                // dRow[0] = thePayment.PaymentID;
                dRow[1] = thePayment.CardType;
                dRow[2] = thePayment.CardName;
                dRow[3] = thePayment.CardNumber;
                dRow[4] = thePayment.CVv;
                dRow[5] = thePayment.ExpiryDate;
                dRow[6] = thePayment.Amount;
                dRow[7] = thePayment.VoucherNumber;
                dRow[8] = thePayment.IsCash;
                dRow[9] = thePayment.BookingNo;
                ds.Tables["PaymentData"].Rows.Add(dRow);
                da.Update(ds, "PaymentData");
                ds = new DataSet();
                da.Fill(ds, "PaymentData");
                thePayment.PaymentID = Convert.ToInt32(ds.Tables["PaymentData"].Rows[totUsers].ItemArray.GetValue(0).ToString());
                thePayment.PrintPaymentDetails();
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                MessageBox.Show(excep.Message);
                //Application.Exit();
                Environment.Exit(1); //Force the application to close
            }
        }//end of function

    }

}
