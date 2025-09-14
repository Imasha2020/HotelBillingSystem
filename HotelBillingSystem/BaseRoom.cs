using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBillingSystem
{
    public class BaseRoom : IRoom
    {
        private double baseRoomCost;
        private int stayedDays;

        public BaseRoom(string roomType, int stayedDays)
        {
            this.stayedDays = stayedDays;
            if (roomType == "standard")
                baseRoomCost = 15000;
            else if (roomType == "double")
                baseRoomCost = 22000;
            else if (roomType == "deluxe")
                baseRoomCost = 30000;
            else
                throw new ArgumentException("Invalid room type");
        }

        public double GetCost()
        {
            return baseRoomCost * stayedDays;
        }
    }
}
