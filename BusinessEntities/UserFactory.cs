using System;

namespace BusinessEntities
{
    public static class UserFactory // Only concern of factory is to create objects. 
    {
        private static IUser user = null;

        public static IUser GetUser(string username, string password, bool isManager, int userID, double salary, string department, string phoneNumber, string position, DateTime startDate)
        {
            if (user != null)  // ie is Factory is primed with an object. 
                return user;
            else
                return new User(username, password, isManager, userID, salary, department, phoneNumber, position, startDate); // Factory coughs up a regular user (for production code) 
        }
        public static void SetUser(IUser aUser)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            user = aUser;
        }
    }

}


