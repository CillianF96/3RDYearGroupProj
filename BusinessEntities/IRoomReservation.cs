using System;

namespace BusinessEntities
{
    public interface IRoomReservation : IReservation
    {
        int RoomReservationID { get; set; }

        DateTime CheckOutDate { get; set; }

        Room Room { get; set; }

        bool KeyReturned { get; set; }

        int MainBookingNumber { get; set; }
        bool IsLateCheckout { get; set; }

        //RoomReservation GetRoomReservation(int bookingNumber, DateTime date, DateTime time, string creditCardNumber, double bill, bool checkedIn, Person person, int roomReservationID, DateTime checkInDate, DateTime checkOutDate, Room room, bool keyReturned, int mainBookingNumber);

        void PrintRoomResvDetails();


    }
}
