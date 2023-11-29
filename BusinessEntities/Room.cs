using System.Collections.Generic;

namespace BusinessEntities
{
    public class Room : IRoom
    {
        private int roomID;
        private int roomNumber;
        private string roomType;
        private int occupancy;
        private double baseRate;
        private List<IKey> keys;

        public Room(int roomID, int roomNumber, string roomType, int occupancy, double baseRate, List<IKey> keys)
        {
            this.roomID = roomID;
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.occupancy = occupancy;
            this.baseRate = baseRate;
            //this.roomResvID = roomResvID;
            this.keys = keys;
        }

        public Room() { }


        // Getter and setter for roomNumber

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        // Getter and setter for roomType
        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        // Getter and setter for occupancy
        public int Occupancy
        {
            get { return occupancy; }
            set { occupancy = value; }
        }

        // Getter and setter for rate
        public double BaseRate
        {
            get { return baseRate; }
            set { baseRate = value; }
        }
        //public int RoomResvID
        //{
        //    get { return roomResvID; }
        //    set { roomResvID = value; }
        //}

        // Getter and setter for keys
        public List<IKey> Keys
        {
            get { return keys; }
            set { keys = value; }
        }
    }
}
