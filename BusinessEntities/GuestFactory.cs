using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class GuestFactory 
    {
        private static IGuest guest = null;

        public static IGuest GetGuest(int personID, string firstName, string lastName, string phoneNumber, string email, int guestID, string address, DateTime dateOfBirth, int personGuestID)
        {
            if (guest != null)  // ie is Factory is primed with an object. 
                return guest;
            else
                return new Guest(personID,firstName, lastName, phoneNumber, email, guestID, address, dateOfBirth, personGuestID);
        }
        public static void SetGuest(IGuest aGuest)   // This provides a seam in the factory where I can prime the factory with the person it will then cough up. (for test code) 
        {
            guest = aGuest;
        }
    }
}
