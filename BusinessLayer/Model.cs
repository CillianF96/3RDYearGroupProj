using BusinessEntities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Person = BusinessEntities.Person;
using Room = BusinessEntities.Room;

namespace BusinessLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;  // Model object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the Model singleton creation. ie in GetInstance () method
        #endregion
        #region Instance Attribures
        private IDataLayer dataLayer;
        private IUser currentUser;
        private List<IUser> userList;
        private List<IProductLine> productLineList = new List<IProductLine>();
        private List<IOrder> orderList;
        private List<IReservation> reservationList = new List<IReservation>();
        private List<IKey> keyList = new List<IKey>();
        private List<IRoom> rooms = new List<IRoom>();

        private List<IPerson> personList = new List<IPerson>();

        private List<IRoom> roomList = new List<IRoom>();

        private List<IVoucher> voucherList = new List<IVoucher>();

        private List<IPayment> paymentList = new List<IPayment>();

        public List<IRoom> RoomList
        {

            get { return roomList; }
            set { roomList = value; }

        }
        public List<IRoom> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public List<IKey> KeyList
        {
            get { return keyList; }
            set { keyList = value; }
        }


        public List<IPerson> PersonList
        {
            get { return personList; }
            set { personList = value; }
        }
        public List<IOrder> OrderList
        {
            get { return orderList; }
            set { orderList = value; }
        }

        public List<IProductLine> ProductLineList
        {
            get { return productLineList; }
            set { productLineList = value; }
        }

        public List<IReservation> ReservationList
        {
            get { return reservationList; }
            set { reservationList = value; }
        }

        public List<IPayment> PaymentList
        {
            get { return paymentList; }
            set { paymentList = value; }
        }

        public List<IVoucher> VoucherList
        {
            get { return voucherList; }
            set { voucherList = value; }
        }

        #endregion
        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }
        public IUser CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }


        public List<IUser> UserList
        {
            get
            {
                return userList;
            }
            //set
            //{
            //}
        }
        #endregion

        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer) // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model(_DataLayer);
                }
                return modelSingletonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            userList = new List<IUser>();
            dataLayer = _DataLayer;
            userList = dataLayer.getAllUsers(); // setup Models userList so we can login
            dataLayer.GetAllRoomReservations().ForEach(reservationList.Add);
            roomList = dataLayer.getRooms();
            PopulatePeople();
        }

        ~Model()
        {
            tearDown();
        }
        #endregion
        public Boolean login(String username, String password)
        {

            //foreach (User user in userList) // now using template so can simplify this code as shown below
            //{
            //    if (name == user.Name && password == user.Password)
            //    {

            //        CurrentUser=user;
            //        return true;
            //    }
            //}
            //return false;

            IUser matchUser = userList.FirstOrDefault(user => user.Username == username && user.Password == password);
            if (matchUser == null)
            {
                return false;
            }
            else
            {
                CurrentUser = matchUser;
                return true;
            }
        }
        public bool addNewUser(string username, string password, bool isManager, double salary, string department, string phoneNumber, string position, DateTime startDate)
        {
            try
            {

                IUser theUser = UserFactory.GetUser(username, password, isManager, -1, salary, department, phoneNumber, position, startDate);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                UserList.Add(theUser);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewUserToDB(theUser); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                Debug.WriteLine(excep.Message);
                MessageBox.Show(excep.Message);
                return false;
            }
        }

        public bool deleteUser(IUser user)
        {

            DataLayer.deleteUserFromDB(user);
            UserList.Remove(user); //remove object from collection
            return true;

        }


        public bool editUser(IUser user)
        {
            DataLayer.editUserInDB(user);
            return true;
        }

        public bool getIsManagerForCurrentUser()
        {
            return currentUser.IsManager;
        }

        public void populateOrders()
        {
            OrderList = dataLayer.getAllOrders(); // setup Models orderList 
                                                  // an order can have one or many productLines so need to setup ProductLineList in each order object.
            foreach (Order order in OrderList)
            {
                order.ProductLineList = DataLayer.getProductLinesForOrder(order.OrderCode); // pass the order code to get back the product lines for the order ie the produc lines that were ordered on that order.
                                                                                            // Each order object has its own ArrayList of reference to ProductLineObjects ie the ProductLines for that specific order.
                                                                                            // Now the small list of ProductLines is sorted for this order so keep looping until the small ProductLineList is set for all orders. 
                foreach (ProductLine productLine in order.ProductLineList)         // There is also an ArrayList for each entity class in the model, these are the big lists. This is an ArrayList of references to all ProductLines (for all orders)
                {
                    this.ProductLineList.Add(productLine); // This adds the reference to the ProductLine to the Models ProductLineList ie big list. 
                }
            }

        }

        public void tearDown()
        {
            DataLayer.closeConnection();
        }

        public bool updateProductLine(IProductLine productLine)
        {
            DataLayer.editProductLineInDB(productLine);
            return true;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------

        public bool editRoomReservation(IRoomReservation reservation)
        {
            DataLayer.editRoomResvInDB(reservation);
            return true;
        }
        public bool addNewPerson(string fisrtName, string lastName, string phoneNumber, string email)
        {
            try
            {

                IPerson theperson = PersonFactory.GetPerson(-1, fisrtName, lastName, phoneNumber, email);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                this.personList.Add(theperson);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewPersonToDB(theperson); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                Debug.WriteLine(excep.Message);
                MessageBox.Show(excep.Message);
                return false;
            }
        }
        public void PopulatePeople()
        {
            PersonList = dataLayer.getAllPeople();
        }

        public bool addNewGuest(int personID, string fisrtName, string lastName, string phoneNumber, string email, string address, DateTime dateOfBirth)
        {
            try
            {
                //int personID;
                //IPerson thePerson = PersonFactory.GetPerson(-1, fisrtName, lastName, phoneNumber, email);
                IGuest theguest = GuestFactory.GetGuest(personID, fisrtName, lastName, phoneNumber, email, -1, address, dateOfBirth, personID);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                personList.Add(theguest);

                //personID = DataLayer.addNewPersonToDB(thePerson);// Add a reference to the newly created object to the Models UserList
                DataLayer.addNewGuestToDB(theguest); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                Debug.WriteLine(excep.Message);
                MessageBox.Show(excep.Message);
                return false;
            }
        }

        public bool addNewRoomReservation(DateTime date, TimeSpan time, string creditCardNumber, double bill, bool checkedIn, Person person, DateTime checkOutDate, Room room, bool keyReturned, bool isLateCheckout)
        {

            //MessageBox.Show(person.PersonID.ToString());
            try
            {

                IRoomReservation theRoomReservation = RoomReservationFactory.GetRoomReservation(-1, date, time, creditCardNumber, bill, checkedIn, person, -1, checkOutDate, room, keyReturned, -1, isLateCheckout);
                //IRoomReservation theRoomReservation = new RoomReservation(-1,DateTime.Today,DateTime.Now,"123445",10.00,true,person,-1,DateTime.Today.AddDays(2),room,true,-1);
                this.ReservationList.Add(theRoomReservation);
                DataLayer.addNewRoomReservationToDB(theRoomReservation);
                //personID = DataLayer.addNewPersonToDB(thePerson);// Add a reference to the newly created object to the Models UserList
                //DataLayer.addNewGuestToDB(theguest, personID); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                Debug.WriteLine(excep.Message);
                MessageBox.Show(excep.Message);
                return false;
            }
        }

        /*
        public Room GetAvailableRoom(DateTime date, string roomType,double bill)
        {
            List<IKey> keys = new List<IKey>(); // Test list of keys. Needs replacing.
            IKey k1 = new Key(false, 5, 5, "five");
            keys.Add(k1);

            if (!roomList.TryGetValue(date, out List<Room> roomsInList) || roomsInList == null)
            {
                // Create the list if it doesn't exist
                roomsInList = new List<Room>();
                roomList[date] = roomsInList;
            }

            int startIdx = 0;
            int endIdx = 0;

            switch (roomType)
            {
                case "Comfort Rooms":
                    startIdx = 0;
                    endIdx = 4;
                    break;
                case "Charm Rooms":
                    startIdx = 4;
                    endIdx = 21;
                    break;
                //case "Deluxe 2 Bedroom Suite":
                    //return RoomFactory.GetRoom(21, roomType, 0, false,bill, 0.0, true, true, keys);
                    
                //default:
                    //return RoomFactory.GetRoom(0, roomType, 0, false, bill, 0.0, true, true, keys);
            }

            Room room = null;

            for (int i = startIdx; i < endIdx; i++)
            {
                if (i >= roomsInList.Count || roomsInList[i].RoomNumber != i + 1)
                {
                    if (!roomsInList.Any(existingRoom => existingRoom.RoomNumber == i + 1))
                    {
                        //room = RoomFactory.GetRoom(i + 1, roomType, 0, false, bill, 0.0, true, true, keys);
                        roomsInList.Add(room);
                        break; // Exit the loop after finding the first empty room
                    }
                }
            }

            return room;
        }
        */

        // Handle the case where no suitable room is found or roomsInList is null.

        public bool DeleteRoomResv(IRoomReservation theRoomReservation)
        {
            try
            {
                dataLayer.deleteRoomReservationFromDB(theRoomReservation);
                reservationList.Remove(theRoomReservation);
            }
            catch (System.Exception excep)
            {
                Debug.WriteLine(excep.Message);
                MessageBox.Show(excep.Message);
                return false;
            }
            return true;
        }

        public bool addNewVoucher(int amount, string name, string type, string message)
        {
            try
            {

                IVoucher thevoucher = VoucherFactory.GetVoucher(-1, amount, name, type, message);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                this.voucherList.Add(thevoucher);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewVoucherToDB(thevoucher); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                Debug.WriteLine(excep.Message);
                MessageBox.Show(excep.Message);
                return false;
            }
        }//end of voucher



        public void SendEmail(string recipientEmail, string datefrom, string dateto, string price)
        {
            try
            {
                string to = recipientEmail;
                string subject = "Confirmation";
                string body1 = $"Booking Confirmed! We would like to welcome you to the consolatio hotel and look forward to meeting you\n" +
                    $"Your stay is from: {datefrom} until: {dateto}\nPrice: {price}";
                //string body1 = "try this";
                string email = "consolatiohotel@outlook.com";

                string password = "college2023";
                string host = "smtp.office365.com";
                int port = 587;

                using (MailMessage mail = new MailMessage(email, to, subject, body1))
                {

                    using (SmtpClient smtpClient = new SmtpClient(host, port))
                    {
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.EnableSsl = true;
                        smtpClient.Credentials = new NetworkCredential(email, password);

                        smtpClient.Send(mail);
                        MessageBox.Show("email sent");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//end of email function

        public void SendCancellationEmail(string recipientEmail, string datefrom, string dateto, string price)
        {
            try
            {
                string to = recipientEmail;
                string subject = "Cancellation";
                string body1 = $"Booking Cancelled! We still look forward to meeting you one day thank you for your custom\n" +
                    $"Your stay is from: {datefrom} until: {dateto}\nPrice Refunded: {price}";
                //string body1 = "try this";
                string email = "consolatiohotel@outlook.com";

                string password = "college2023";
                string host = "smtp.office365.com";
                int port = 587;

                using (MailMessage mail = new MailMessage(email, to, subject, body1))
                {

                    using (SmtpClient smtpClient = new SmtpClient(host, port))
                    {
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.EnableSsl = true;
                        smtpClient.Credentials = new NetworkCredential(email, password);

                        smtpClient.Send(mail);
                        MessageBox.Show("email sent");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//end of cancel email function

        public bool addNewPayment(int paymentID, string cardType, string cardName, string cardNumber, string Cvv, DateTime expiryDate, double amount, int voucherNumber, bool isCash, int bookingNo)
        {
            try
            {

                IPayment thepayment = PaymentFactory.GetPayment(-1, cardType, cardName, cardNumber, Cvv, expiryDate, amount, voucherNumber, isCash, bookingNo);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                this.paymentList.Add(thepayment);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewPaymentToDB(thepayment); //Gets the DataLayer to add the new user to the DB. 
                writeReceipt(thepayment);
                return true;
            }
            catch (System.Exception excep)
            {
                Debug.WriteLine(excep.Message);
                MessageBox.Show(excep.Message);
                return false;
            }
        }//end of function

        private void writeReceipt(IPayment payment)
        {
            string docPath = @".\";
            string[] paymentLines = payment.GetPaymentLines();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "P-" + payment.PaymentID.ToString() + ".txt")))
            {
                foreach (string line in paymentLines)
                    outputFile.WriteLine(line);
            }
        }

        public void PopulateVoucher()
        {
            VoucherList = dataLayer.getAllVouchers();
        }


    }
}
