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
    public partial class MakeBooking : Form
    {
        AirlineCoordinator aCoord;
        public MakeBooking()
        { InitializeComponent(); }

        public MakeBooking(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void MakeBooking_Load(object sender, EventArgs e)
        {
            txtCustomerList.Text = aCoord.customerList();
            txtFlightList.Text = aCoord.flightList();
        }

        public bool checkInteger(TextBox t)
        { return int.TryParse(t.Text, out int i); }

        public bool isEmpty(TextBox t)
        { return String.IsNullOrEmpty(t.Text); }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            if (checkInteger(txtCustID) && !isEmpty(txtCustID) && checkInteger(txtFlightID)
                && !isEmpty(txtFlightID))
            {
                int customerId = Convert.ToInt32(txtCustID.Text);
                int flightId = Convert.ToInt32(txtFlightID.Text);
                if (aCoord.addBooking(customerId, flightId))
                {
                    MessageBox.Show("Booking successfully added", "Made Booking");
                    ViewBookings vb = new ViewBookings(aCoord);
                    this.Hide();
                    vb.Show();
                }
                else
                {
                    MessageBox.Show("Booking was not made..", "Made Booking");
                }
            }
            else
                lblError.Text = "*Please enter valid inputs.";
            {
                //Validating inputs
                if (!checkInteger(txtCustID) || (isEmpty(txtCustID)))
                {
                    txtCustID.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
                }
                else if (!checkInteger(txtFlightID) || (isEmpty(txtFlightID)))
                {
                    txtFlightID.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BookingMenu bm = new BookingMenu(aCoord);
            this.Hide();
            bm.Show();
        }
    }
}
