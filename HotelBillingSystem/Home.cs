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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCustom_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomerFormcs addCustom = new AddCustomerFormcs();
            addCustom.Show();
        }

        private void buttonViewCheckouts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewDailyCheckoutsForm viewdCheckouts = new ViewDailyCheckoutsForm();
            viewdCheckouts.Show();
        }
    }
}
