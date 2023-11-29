using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class KeyFactory
    {
        private static Key key = null;
        public static Key GetKey(bool active, int roomNumber, int keyID, string keyCode)
        {
            if (key != null)  // ie is Factory is primed with an object. 
                return key;
            else
                return new Key(active,roomNumber,keyID,keyCode); // Factory coughs up a regular user (for production code) 
        }
        public static void SetKey(Key aKey)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            key = aKey;
        }
    }
}
