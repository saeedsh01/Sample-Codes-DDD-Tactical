using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDEorkShop.Entities.Invariants
{
    public class HotelRoomSummary
    {
        public int NumberOfSingleRooms { get; private set; }
        public int NumberOfDoubleRooms { get; private set; }
        public int NumberOfFamilyRooms { get; private set; }
    }
}
