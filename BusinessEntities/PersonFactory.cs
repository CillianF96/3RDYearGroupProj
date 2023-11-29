using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class PersonFactory
    {
        private static IPerson person = null;

        public static IPerson GetPerson(int personID, string firstName, string lastName,string phoneNumber,string email)
        {
            if (person != null)  // ie is Factory is primed with an object. 
                return person;
            else
                return new Person(personID, firstName, lastName, phoneNumber, email);
        }
        public static void SetPerson(IPerson aPerson)   // This provides a seam in the factory where I can prime the factory with the person it will then cough up. (for test code) 
        {
            person = aPerson;
        }
    }
}
