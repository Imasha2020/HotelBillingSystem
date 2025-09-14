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
    public partial class ViewDailyCheckoutsForm : Form
    {
        public ViewDailyCheckoutsForm()
        {
            InitializeComponent();
        }

        private void BackHomeBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var customers = CustomerList.GetAllCustomers();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = customers;

        }
    }
}
