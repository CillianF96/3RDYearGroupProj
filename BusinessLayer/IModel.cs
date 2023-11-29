using BusinessEntities;
using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public interface IModel
    {
        bool addNewUser(string username, string password, bool isManager, double salary, string department, string phoneNumber, string position, DateTime startDate);
        BusinessEntities.IUser CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        bool deleteUser(IUser user);
        bool editUser(BusinessEntities.IUser user);
        bool getIsManagerForCurrentUser();
        bool login(string username, string password);
        List<IProductLine> ProductLineList { get; set; }
        void tearDown();
        List<IUser> UserList { get; }

        List<IKey> KeyList { get; set; }
        List<IOrder> OrderList { get; set; }
        List<IReservation> ReservationList { get; set; }
        //Room GetAvailableRoom(DateTime date, string roomType,double bill);
        void populateOrders();
        void PopulatePeople();
        bool updateProductLine(IProductLine productLine);

        List<IPerson> PersonList { get; set; }
        List<IRoom> Rooms { get; set; }

        List<IVoucher> VoucherList { get; set; }


        bool editRoomReservation(IRoomReservation reservation);
        bool addNewPerson(string fisrtName, string lastName, string phoneNumber, string email);

        bool addNewGuest(int personID, string fisrtName, string lastName, string phoneNumber, string email, string address, DateTime dateOfBirth);

        bool addNewRoomReservation(DateTime date, TimeSpan time, string creditCardNumber, double bill, bool checkedIn, Person person, DateTime checkOutDate, Room room, bool keyReturned, bool isLateCheckIn);

        List<IRoom> RoomList { get; set; }

        List<IPayment> PaymentList { get;set; }

        bool DeleteRoomResv(IRoomReservation theRoomReservation);

        bool addNewVoucher(int amount, string name, string type, string message);

        void SendEmail(string recipientEmail, string datefrom, string dateto, string price);

        void SendCancellationEmail(string recipientEmail, string datefrom, string dateto, string price);

        bool addNewPayment(int paymentID, string cardType, string cardName, string cardNumber, string Cvv, DateTime expiryDate, double amount, int voucherNumber, bool isCash, int bookingNo);

        void PopulateVoucher();
    }
}





