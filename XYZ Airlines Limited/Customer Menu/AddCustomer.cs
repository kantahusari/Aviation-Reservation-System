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
    public partial class AddCustomer : Form
    {
        AirlineCoordinator aCoord;
        public AddCustomer()
        { InitializeComponent(); }

        public AddCustomer(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        public bool checkInteger(TextBox t)
        { return double.TryParse(t.Text, out double i); }

        public bool isEmpty(TextBox t)
        { return String.IsNullOrEmpty(t.Text); }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!isEmpty(txtPhoneNumber) && checkInteger(txtPhoneNumber)
                && !isEmpty(txtFirstName) && !isEmpty(txtLastName))
            {
                string fname = txtFirstName.Text;
                string lname = txtLastName.Text;
                string phone = txtPhoneNumber.Text;
                if (aCoord.addCustomer(fname, lname, phone))
                {
                    MessageBox.Show("Customer is successfully added", "Add Customer");
                    ViewCustomers vc = new ViewCustomers(aCoord);
                    this.Hide();
                    vc.Show();
                }
                else
                {
                    MessageBox.Show("Customer was not added..", "Add Customer");
                }
            }
            else
                lblError.Text = "Please enter valid inputs.";
            {
                //Validating inputs
                if (isEmpty(txtFirstName))
                {
                    txtFirstName.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
                }
                else if (isEmpty(txtLastName))
                {
                    txtLastName.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
                }
                else if ((isEmpty(txtPhoneNumber)) || !checkInteger(txtPhoneNumber))
                {
                    txtPhoneNumber.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerMenu cm = new CustomerMenu(aCoord);
            this.Hide();
            cm.Show();
        }
    }
}
