using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBillingSystem
{
    public class DiningDecorator : BaseDecorator
    {
        double additionalPrice;
        public DiningDecorator(IRoom room, double price) : base(room)
        {
            additionalPrice = price;

        }

        public override double GetCost()
        {
            return base.GetCost() + additionalPrice*1.1; // Fixed bdining charge
        }
    }
}
