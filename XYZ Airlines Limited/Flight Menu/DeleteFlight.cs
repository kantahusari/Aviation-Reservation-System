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
    public partial class DeleteFlight : Form
    {
        AirlineCoordinator aCoord;
        public DeleteFlight()
        { InitializeComponent(); }

        public DeleteFlight(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        private void DeleteFlight_Load(object sender, EventArgs e)
        {
            txtFlightList.Text = aCoord.flightList();
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFlightNum.Text);
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the flight?", "Delete Flight", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    if (aCoord.deleteFlight(id))
                    {
                        MessageBox.Show("Flight with id " + id + " deleted.", "Delete Flight");
                        // Refresh page
                        DeleteFlight df = new DeleteFlight(aCoord);
                        this.Hide();
                        df.Show();
                    }
                    else
                    {
                        MessageBox.Show("Flight with id " + id + " was not found..", "Delete Flight");
                    }
                    break;
                case DialogResult.No:
                    break;
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FlightMenu fm = new FlightMenu(aCoord);
            this.Hide();
            fm.Show();
        }

    }
}
