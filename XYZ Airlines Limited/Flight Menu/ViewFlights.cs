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
    public partial class ViewFlights : Form
    {

        AirlineCoordinator aCoord;
        public ViewFlights()
        { InitializeComponent(); }

        public ViewFlights(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            txtFlightList.Text = aCoord.flightList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FlightMenu fm = new FlightMenu(aCoord);
            this.Hide();
            fm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFlight af = new AddFlight(aCoord);
            Hide();
            af.Show();
        }

    }
}
