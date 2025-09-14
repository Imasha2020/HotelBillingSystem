using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBillingSystem
{
    public class Customer
    {
        public string No { get; set; }
        public string Name { get; set; }
        public DateTime checkInDate { get; set; }
        public string roomType {get; set;}
        public double barCharge { get; set; }
        public double diningCharge { get; set; }
        public double wellnessCharge { get; set; }
        public double airportCharge { get; set; }

        public double totalBill { get; set; }
    }
}
