using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBillingSystem
{
    public class WellnessDecorator : BaseDecorator
    {
        double additionalPrice;
        public WellnessDecorator(IRoom room, double price) : base(room)
        {
            additionalPrice = price;

        }

        public override double GetCost()
        {
            return base.GetCost() + additionalPrice; // Fixed wellness charge
        }
    }
}
