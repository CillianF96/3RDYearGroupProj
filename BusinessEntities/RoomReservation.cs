using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class RoomReservation : Reservation, IRoomReservation


    {
        private int roomReservationID;

        private DateTime checkOutDate;

        private Room room;

        private bool keyReturned;

        private int mainBookingNumber;

        private bool isLateCheckout;

        public RoomReservation(int bookingNumber, DateTime date, TimeSpan time, string creditCardNumber, double bill, bool checkedIn, Person person, int roomReservationID, DateTime checkOutDate, Room room, bool keyReturned, int mainBookingNumber, bool isLateCheckout)
            : base(bookingNumber, date, time, creditCardNumber, bill, checkedIn, person)
        {
            this.roomReservationID = roomReservationID;
            this.checkOutDate = checkOutDate;
            this.room = room;
            this.keyReturned = keyReturned;
            this.mainBookingNumber = mainBookingNumber;
            this.isLateCheckout = isLateCheckout;
        }

        public RoomReservation() { }

        [DisplayName("Reservation ID")]
        public int RoomReservationID
        {
            get { return roomReservationID; }
            set { roomReservationID = value; }
        }



        // Getter and setter for checkOutDate
        [DisplayName("Check Out Date")]
        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        // Getter and setter for room
        [Browsable(false)]
        public Room Room
        {
            get { return room; }
            set { room = value; }
        }

        // Getter and setter for keyReturned
        [DisplayName("Key Returned")]
        public bool KeyReturned
        {
            get { return keyReturned; }
            set { keyReturned = value; }
        }

        [Browsable(false)]
        public int MainBookingNumber
        {
            get { return mainBookingNumber; }
            set { mainBookingNumber = value; }
        }

        [DisplayName("Late Checkout")]
        public bool IsLateCheckout
        {
            get { return isLateCheckout; }
            set { isLateCheckout = value; }
        }
        public void PrintRoomResvDetails()
        {
            string properties = GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
            Debug.WriteLine(properties);
        }

    }
}
