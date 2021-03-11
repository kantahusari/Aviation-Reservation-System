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
    public partial class ViewBookings : Form
    {
        AirlineCoordinator aCoord;
        public ViewBookings()
        { InitializeComponent(); }

        public ViewBookings(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }
        private void ViewBookings_Load(object sender, EventArgs e)
        {
            string[] booklist = aCoord.bookingList().Split('\n');
            foreach (string passenger in booklist)
                grdBookList.Rows.Add(passenger.Split('\t'));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BookingMenu bm = new BookingMenu(aCoord);
            this.Hide();
            bm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MakeBooking mb = new MakeBooking(aCoord);
            this.Hide();
            mb.Show();
        }
    }
}
