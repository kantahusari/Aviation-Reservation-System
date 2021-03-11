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
    
    public partial class SplashScreen : Form
    {
        AirlineCoordinator aCoord;
        public SplashScreen()
        {
            InitializeComponent();
        }

        public SplashScreen(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                Home h = new Home(aCoord);
                this.Hide();
                h.Show();
            }
        }

    }
}
