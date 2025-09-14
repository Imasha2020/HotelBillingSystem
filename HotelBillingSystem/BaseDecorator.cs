using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBillingSystem
{
    public abstract class BaseDecorator : IRoom
    {
        protected IRoom room;

        public BaseDecorator(IRoom room)
        {
            this.room = room;
        }

        public virtual double GetCost()
        {
            return room.GetCost();
        }
    }
}
