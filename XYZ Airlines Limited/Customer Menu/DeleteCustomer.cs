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
    public partial class DeleteCustomer : Form
    {
        AirlineCoordinator aCoord;
        public DeleteCustomer()
        { InitializeComponent(); }
        public DeleteCustomer(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerList.Text = aCoord.customerList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerMenu cm = new CustomerMenu(aCoord);
            this.Hide();
            cm.Show();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCustomerNum.Text);
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the customer?", "Delete Customer", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                if (aCoord.deleteCustomer(id))
                {
                    MessageBox.Show("Customer with id " + id + " deleted", "Delete Customer");
                    // Refresh page
                    DeleteCustomer df = new DeleteCustomer(aCoord);
                    this.Hide();
                    df.Show();
                }
                else
                {
                    MessageBox.Show("Customer with id " + id + " was not found..", "Delete Customer");
                }
                    break;
                case DialogResult.No:
                    break;
            }
        }

    }
}
