using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Key : IKey
    {
        private bool active;

        private int roomNumber;

        private int keyID;

        private string keyCode;

        public Key(bool active, int roomNumber, int keyID, string keyCode)
        {
            this.active = active;
            this.roomNumber = roomNumber;
            this.keyID = keyID;
            this.keyCode = keyCode;
        }

        // Getter and setter for active
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        // Getter and setter for roomNumber
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        // Getter and setter for keyID
        public int KeyID
        {
            get { return keyID; }
            set { keyID = value; }
        }

        // Getter and setter for keyCode
        public string KeyCode
        {
            get { return keyCode; }
            set { keyCode = value; }
        }

    }
}
