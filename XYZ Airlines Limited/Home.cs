using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace XYZ_Airlines_Limited
{
    public partial class Home : Form
    {
        AirlineCoordinator aCoord;
        public Home()
        {
            InitializeComponent();
        }
        public Home(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void btnFlightMenu_Click(object sender, EventArgs e)
        {
            FlightMenu fm = new FlightMenu(aCoord);
            this.Hide();
            fm.Show();
        }

        private void btnCustomerMenu_Click(object sender, EventArgs e)
        {
            CustomerMenu cm = new CustomerMenu(aCoord);
            this.Hide();
            cm.Show();
        }

        private void btnBookingMenu_Click(object sender, EventArgs e)
        {
            BookingMenu bm = new BookingMenu(aCoord);
            this.Hide();
            bm.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        { Application.Exit(); }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our app. Fly with us again soon!", "XYZ Airlines Limited");
            Application.Exit();
        }
    }
}
