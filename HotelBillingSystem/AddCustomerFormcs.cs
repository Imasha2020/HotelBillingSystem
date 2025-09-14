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

            double barCharges = double.Parse(BarChargeTxtBox.Text);
            double resturantCharges = double.Parse(ResturantChargesTxtBox.Text);
            double wellnessCharges = double.Parse(WellnessChargesTxtBox.Text);
            double airportPickupCharges = double.Parse(AirPortChargesTxtBox.Text);

            DateTime checkInDate = CheckInDate.Value;
            DateTime checkOutDate = DateTime.Now;

            int stayedDays = (checkOutDate - checkInDate).Days + 1;



        }
    }
}
