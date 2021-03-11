using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Airlines_Limited
{
    static class Program
    {
        /******************************************/
        /*              Created by:               */
        /*             Adrian Filipe,             */
        /*             Kanta Hussari,             */
        /*              and Jes Muli              */
        /*                c. 2019                 */
        /******************************************/


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AirlineCoordinator aCoord = new AirlineCoordinator(100, 2, 30);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen(aCoord));
        }
    }
}
