using BusinessEntities;
using System;
using System.Collections;
using System.Collections.Generic;
namespace DataAccessLayer
{
    public interface IDataLayer
    {

        void addNewUserToDB(BusinessEntities.IUser theUser);

        bool deleteUserFromDB(BusinessEntities.IUser user);
        bool editUserInDB(BusinessEntities.IUser user);
        void closeConnection();
        List<IUser> getAllUsers();
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();
        List<IOrder> getAllOrders();
        List<IProductLine> getProductLinesForOrder(int OrderCode);

        bool editProductLineInDB(BusinessEntities.IProductLine productLine);
        int addNewPersonToDB(IPerson theperson);
        List<IPerson> getAllPeople();
        bool deletePersonFromDB(BusinessEntities.IPerson person);

        void addNewGuestToDB(IGuest theguest);

        void addNewRoomReservationToDB(IRoomReservation theRoomreservation);

        void addNewRoomToDB(IRoom theRoom);
        //bool editReservationInDB(IReservation reservation);
        bool editRoomResvInDB(IRoomReservation roomResv);
        void addReservationToDB(IReservation reservation);

        void addNewPaymentToDB(IPayment thePayment);
        List<IRoomReservation> GetAllRoomReservations();

        Room getRoomByID(int roomID);
        List<IRoom> getRooms();

        bool deleteRoomReservationFromDB(BusinessEntities.IRoomReservation theRoomResv);

        int addNewVoucherToDB(IVoucher thevoucher);

        List<IVoucher> getAllVouchers();
    }
}
