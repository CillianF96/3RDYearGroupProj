 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Person : BusinessEntities.IPerson
    {
        private int personID;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;

        [DisplayName("Person ID")]
        public int PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        [DisplayName("First Name")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        [DisplayName("Last Name")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [DisplayName("Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [DisplayName("Phone Number")]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        [DisplayName("Email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    

        public Person(int personID, string firstName, string lastName, string phoneNumber, string email)
        {
            this.personID = personID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public Person() { }

        public void PrintPersonDetails()
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
