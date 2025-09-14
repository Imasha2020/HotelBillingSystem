using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBillingSystem
{
    public class BarDecorator : BaseDecorator
    {
        double additionalPrice;
        public BarDecorator(IRoom room , double price) : base(room)
        {
            additionalPrice = price;

        }

        public override double GetCost()
        {
            return base.GetCost() + additionalPrice*1.1 ; // Fixed bar charge
        }
    }
}
