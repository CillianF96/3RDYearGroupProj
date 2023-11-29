using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IGuest:IPerson
    {
        //string FirstName { get; set; }
        //string LastName { get; set; }
        //string PhoneNumber { get; set; }
        //string Email { get; set; }
        int GuestID { get; set; }
        string Address { get; set; }
        DateTime DateOfBirth { get; set; }
        int PersonGuestID { get; set; }
        string GetGuest();
    }
}
