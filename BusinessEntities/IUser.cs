using System;

namespace BusinessEntities
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        bool IsManager { get; set; }
        int UserID { get; set; }
        DateTime StartDate { get; set; }
        double Salary { get; set; }
        string Department { get; set; }
        string Position { get; set; }
        string PhoneNumber { get; set; }
        void PrintUserDetails();

    }
}
