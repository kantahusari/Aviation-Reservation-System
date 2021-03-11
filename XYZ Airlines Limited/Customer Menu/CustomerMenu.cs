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
    public partial class CustomerMenu : Form
    {
        AirlineCoordinator aCoord;
        public CustomerMenu()
        { InitializeComponent(); }
        public CustomerMenu(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord; 
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer(aCoord);
            Hide();
            ac.Show();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomers vc = new ViewCustomers(aCoord);
            Hide();
            vc.Show();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomer dc = new DeleteCustomer(aCoord);
            Hide();
            dc.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Home h = new Home(aCoord);
            Hide();
            h.Show();
        }

    }
}
