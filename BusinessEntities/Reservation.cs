using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public abstract class Reservation : BusinessEntities.IReservation
    {
        private int bookingNumber;

        private DateTime date;

        private TimeSpan time;

        private string creditCardNumber;

        private double bill;

        private Boolean checkedIn;

        private Person person;

        public Reservation(int bookingNumber, DateTime date, TimeSpan time, string creditCardNumber, double bill, bool checkedIn, Person person)
            : base()
        {
            this.bookingNumber = bookingNumber;
            this.date = date;
            this.time = time;
            this.creditCardNumber = creditCardNumber;
            this.bill = bill;
            this.checkedIn = checkedIn;
            this.person = person;
        }

        public Reservation() { }

        [DisplayName("Booking Number")]
        public int BookingNumber
        {
            get { return bookingNumber; }
            set { bookingNumber = value; }
        }

        // Getter and setter for date
        [DisplayName("Date")]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        // Getter and setter for time
        [DisplayName("Time")]
        public TimeSpan Time
        {
            get { return time; }
            set { time = value; }
        }

        // Getter and setter for creditCardNumber
        [DisplayName("Credit Card Number")]
        public string CreditCardNumber
        {
            get { return creditCardNumber; }
            set { creditCardNumber = value; }
        }

        // Getter and setter for bill
        [DisplayName("Bill")]
        public double Bill
        {
            get { return bill; }
            set { bill = value; }
        }

        // Getter and setter for checkedIn
        [DisplayName("Checked In")]
        public bool CheckedIn
        {
            get { return checkedIn; }
            set { checkedIn = value; }
        }

        // Getter and setter for person
        //[Browsable(false)]
        public Person Person
        {
            get { return person; }
            set { person = value; }
        }
    }
}
