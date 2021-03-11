using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Airlines_Limited
{
    public partial class ViewCustomers : Form
    {
        AirlineCoordinator aCoord;
        public ViewCustomers()
        { InitializeComponent(); }
        public ViewCustomers(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            txtCustomerList.Text = aCoord.customerList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerMenu cm = new CustomerMenu(aCoord);
            this.Hide();
            cm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer(aCoord);
            this.Hide();
            ac.Show();
        }

    }
}
