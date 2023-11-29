using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Guest :Person, IGuest
    {
        private int guestID;
        private string address;
        private DateTime dateOfBirth;
        private int personGuestID;

        public Guest()
        {
        }

        public Guest(int personID, string firstName, string lastName, string phoneNumber, string email, int guestID, string address, DateTime dateOfBirth, int personGuestID) 
            : base(personID, firstName, lastName, phoneNumber, email)
        {
            this.guestID = guestID;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.personGuestID = personID;
        }

        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public int PersonGuestID
        {
            get
            {
                return personGuestID;
            }
            set
            {
                personGuestID = value;
            }
        }


        public string GetGuest()
        {
            return "Guest: " + FirstName + " " + LastName + " " + PhoneNumber + " " + Email + " " + Address + " " + DateOfBirth;
        }


    }
}

