using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XYZ_Airlines_Limited
{
    public partial class AddFlight : Form
    {
        AirlineCoordinator aCoord;
        public AddFlight()
        { InitializeComponent(); }

        public AddFlight(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        public bool checkInteger(TextBox t)
        { return int.TryParse(t.Text, out int i); }

        public bool isEmpty(TextBox t)
        { return String.IsNullOrEmpty(t.Text); }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (checkInteger(txtFlightNumber) && !isEmpty(txtFlightNumber) && checkInteger(txtMaxSeats)
                && !isEmpty(txtMaxSeats) && !isEmpty(txtOrigin) && !isEmpty(txtDestination))
            {
                int flightNo = Convert.ToInt32(txtFlightNumber.Text);
                int maxSeats = Convert.ToInt32(txtMaxSeats.Text);
                string origin = txtOrigin.Text;
                string destination = txtDestination.Text;
                if (aCoord.addFlight(flightNo, origin, destination, maxSeats))
                {
                    MessageBox.Show("Flight was successfully added", "Add Flight");
                    ViewFlights vf = new ViewFlights(aCoord);
                    this.Hide();
                    vf.Show();
                }
                else
                {
                    MessageBox.Show("Flight was not added", "Add Flight");
                }
            }
            else
                lblError.Text = "Please enter valid inputs.";
            {
                //Validating inputs
                if (!checkInteger(txtFlightNumber) || (isEmpty(txtFlightNumber)))
                {
                    txtFlightNumber.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
                }
                else if (!checkInteger(txtMaxSeats) || (isEmpty(txtMaxSeats)))
                {
                    txtMaxSeats.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
                }
                else if (isEmpty(txtOrigin))
                {
                    txtOrigin.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
                }
                else if (isEmpty(txtDestination))
                {
                    txtDestination.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
                }
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