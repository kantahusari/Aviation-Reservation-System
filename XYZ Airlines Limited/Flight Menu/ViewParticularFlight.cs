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
    public partial class ViewParticularFlight : Form
    {
        AirlineCoordinator aCoord;
        public ViewParticularFlight()
        { InitializeComponent(); }

        public ViewParticularFlight(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void ViewParticularFlight_Load(object sender, EventArgs e)
        {
            txtFlightList.Text = aCoord.flightList();
        }

        private void btnViewFlight_Click(object sender, EventArgs e)
        {
            int fnum = Convert.ToInt32(txtFlightNum.Text);
            txtFlightDetails.Text = aCoord.viewflight(fnum);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FlightMenu fm = new FlightMenu(aCoord);
            this.Hide();
            fm.Show();
        }

    }
}
