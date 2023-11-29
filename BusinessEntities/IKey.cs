using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IKey
    {
        bool Active { get; set; }
        int RoomNumber { get; set; }
        int KeyID { get; set; }
        string KeyCode { get; set; }
    }
}
