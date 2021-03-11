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
    public partial class BookingMenu : Form
    {
        AirlineCoordinator aCoord;
        public BookingMenu()
        { InitializeComponent(); }

        public BookingMenu(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;

            InitializeComponent();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            MakeBooking mb = new MakeBooking(aCoord);
            Hide();
            mb.Show();
        }

        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            ViewBookings vb = new ViewBookings(aCoord);
            Hide();
            vb.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Home h = new Home(aCoord);
            Hide();
            h.Show();
        }

    }
}
