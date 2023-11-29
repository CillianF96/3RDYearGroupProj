using System.Collections.Generic;

namespace BusinessEntities
{
    public interface IRoom
    {
        int RoomID { get; set; }
        int RoomNumber { get; set; }
        string RoomType { get; set; }
        int Occupancy { get; set; }
        double BaseRate { get; set; }
        List<IKey> Keys { get; set; }
    }
}
