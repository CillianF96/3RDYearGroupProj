using System;

namespace BusinessEntities
{
    public static class RoomReservationFactory
    {
        private static RoomReservation roomReservation = null;
        public static RoomReservation GetRoomReservation(int bookingNumber, DateTime date, TimeSpan time, string creditCardNumber, double bill, bool checkedIn, Person person, int roomReservationID, DateTime checkOutDate, Room room, bool keyReturned, int mainBookingNumber, bool isLateCheckout)
        {
            if (roomReservation != null)  // ie is Factory is primed with an object. 
            { return roomReservation; }
            else
            {
                return new RoomReservation(bookingNumber, date, time, creditCardNumber, bill, checkedIn, person, roomReservationID, checkOutDate, room, keyReturned, mainBookingNumber, isLateCheckout); // Factory coughs up a regular user (for production code)

            }


        }

        public static void SetRoomReservation(RoomReservation aroomReservation)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            roomReservation = aroomReservation;
        }
    }
}
