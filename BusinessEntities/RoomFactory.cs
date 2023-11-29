using System.Collections.Generic;

namespace BusinessEntities
{
    public static class RoomFactory
    {

        private static Room room = null;
        public static Room GetRoom(int roomID, int roomNumber, string roomType, int occupancy, double baseRate, List<IKey> key)
        {
            if (room != null)  // ie is Factory is primed with an object. 
                return room;
            else
                return new Room(roomID, roomNumber, roomType, occupancy, baseRate, key); // Factory coughs up a regular user (for production code) 
        }
        public static void SetRoom(Room aRoom)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            room = aRoom;
        }
    }
}
