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
    public partial class FlightMenu : Form
    {
        AirlineCoordinator aCoord;
        public FlightMenu()
        { InitializeComponent(); }

        public FlightMenu(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            AddFlight af = new AddFlight(aCoord);
            Hide();
            af.Show();
        }
        
        private void btnViewFlights_Click(object sender, EventArgs e)
        {
            ViewFlights vf = new ViewFlights(aCoord);
            Hide();
            vf.Show();
        }

        private void btnViewParticularFlight_Click(object sender, EventArgs e)
        {
            ViewParticularFlight vpf = new ViewParticularFlight(aCoord);
            Hide();
            vpf.Show();
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            DeleteFlight df = new DeleteFlight(aCoord);
            Hide();
            df.Show();
        }


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Home h = new Home(aCoord);
            Hide();
            h.Show();
        }

        private void FlightMenu_FormClosed(object sender, FormClosedEventArgs e)
        { Application.Exit(); }
    }
}
