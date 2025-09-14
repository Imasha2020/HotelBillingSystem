using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBillingSystem
{
    public class CustomerList
    {
        private static List<Customer> customers = new List<Customer>();

        public static void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public static List<Customer> GetAllCustomers()
        {
            return customers;
        }
    }
}
