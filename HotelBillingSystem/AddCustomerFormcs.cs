using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBillingSystem
{
    public partial class AddCustomerFormcs : Form
    {
        public AddCustomerFormcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void AddCustomBtn_Click(object sender, EventArgs e)
        {
            //1.Get User Inputs
            String name = CustomerNameTxtBox.Text;
            String roomType = "";

            if (standardRadio.Checked)
                roomType = "standard";
            else if (doubleRadio.Checked)
                roomType = "double";
            else if (DeluxeRadio.Checked)
                roomType = "deluxe";

            //double barCharges = 0, resturantCharges = 0, wellnessCharges = 0, airportPickupCharges = 0;

            //double.TryParse(BarChargeTxtBox.Text, out barCharges);
            //double.TryParse(ResturantChargesTxtBox.Text, out resturantCharges);
            //double.TryParse(WellnessChargesTxtBox.Text, out wellnessCharges);
            //double.TryParse(AirPortChargesTxtBox.Text, out airportPickupCharges);

            double barCharges = double.Parse(BarChargeTxtBox.Text);
            double resturantCharges = double.Parse(ResturantChargesTxtBox.Text);
            double wellnessCharges = double.Parse(WellnessChargesTxtBox.Text);
            double airportPickupCharges = double.Parse(AirPortChargesTxtBox.Text);


            DateTime checkInDate = CheckInDate.Value;
            DateTime checkOutDate = DateTime.Now;

            int stayedDays = (checkOutDate - checkInDate).Days + 1;


            //2.Base room Cost
            IRoom room = new BaseRoom(roomType, stayedDays);
            double baseRoomCost = room.GetCost();

            //3.Apply Decorators
            if (barCharges > 0)
                room = new BarDecorator(room, barCharges);
            if (resturantCharges > 0)
                room = new DiningDecorator(room, resturantCharges);
            if (wellnessCharges > 0)
                room = new WellnessDecorator(room, wellnessCharges);
            if (airportPickupCharges > 0)
                room = new AirportDecorator(room, airportPickupCharges);

            //4.Total Cost
            double totalCost = room.GetCost();

            //5.Save Customer

            int nextNo = CustomerList.GetNextCustomerNo();

            Customer customer = new Customer { 
                No = nextNo.ToString(),
                Name = name ,
                checkInDate = checkInDate,
                roomType = roomType,
                barCharge = barCharges,
                diningCharge = resturantCharges,
                wellnessCharge = wellnessCharges,
                airportCharge = airportPickupCharges,
                totalBill = totalCost
            };

            CustomerList.AddCustomer(customer);

            MessageBox.Show("Customer Added Successfully!");
        }
    }
}
