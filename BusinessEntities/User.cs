using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class User : BusinessEntities.IUser
    {
        #region Instance Properties
        private string username;
        private string password;
        private bool isManager;
        private int userID;
        private DateTime startDate;
        private double salary;
        private string department;
        private string phoneNumber;
        private string position;

        #endregion

        #region Instance Properties
        [DisplayName("User ID")]
        public int UserID { get { return userID; } set { userID = value; } }

        [DisplayName("Username")]
        public string Username { get { return username; } set { username = value; } }

        [DisplayName("Password")]
        public string Password { get { return password; } set { password = value; } }

        [DisplayName("Start Date")]
        public DateTime StartDate { get { return startDate; } set { startDate = value; } }

        [DisplayName("Salary")]
        public double Salary { get { return salary; } set { salary = value; } }

        [DisplayName("Department")]
        public string Department { get { return department; } set { department = value; } }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

        [DisplayName("Position")]
        public string Position { get { return position; } set { position = value; } }

        [DisplayName("Manager")]
        public bool IsManager { get { return isManager; } set { isManager = value; } }



        #endregion
        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(string username, string password, bool isManager, int userID, double salary, string department, string phoneNumber, string position, DateTime startDate)
        {
            this.username = username;
            this.password = password;
            this.isManager = isManager;
            this.userID = userID;
            this.salary = salary;
            this.department = department;
            this.phoneNumber = phoneNumber;
            this.position = position;
            this.startDate = startDate;
        }

        #endregion

        public void PrintUserDetails()
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
