using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_Airlines_Limited
{
    class FlightManager
    {
        private int maxFlights;
        private int numFlights;
        private Flight[] flightList;

        public FlightManager(int max)
        {
            maxFlights = max;
            numFlights = 0;
            flightList = new Flight[maxFlights];
        }

        public bool addFlight(int fn, string origin, string destination, int maxSeats)
        {
            if (findFlight(fn) == -1)
            {
                if (numFlights >= maxFlights) { return false; }
                Flight f = new Flight(fn, origin, destination, maxSeats);
                flightList[numFlights] = f;
                numFlights++;
                return true;
            }
            return false;
        }

        public int findFlight(int fid)
        {
            for (int x = 0; x < numFlights; x++)
            {
                if (flightList[x].getFlightNumber() == fid)
                    return x;
            }
            return -1;
        }

        public bool flightExists(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            return true;
        }

        public Flight getFlight(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return null; }
            return flightList[loc];
        }

        public bool deleteFlight(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            flightList[loc] = flightList[numFlights - 1];
            numFlights--;
            return true;
        }

        public int getNumFlights() { return numFlights; }

        public string viewFlight(int fnum)
        {
            string s = "";
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].getFlightNumber() == fnum)
                {
                    s += "\n" + flightList[i].toString();
                }
            }
            return s;
        }

        public string getFlightList()
        {
            string s ="";
            for (int x = 0; x < numFlights; x++)
            {
                s = s + flightList[x].getFlightNumber()
                      + " from " + flightList[x].getOrigin()
                      + " to " + flightList[x].getDestination() + "\r\n";
            }
            return s;
        }
    }
}
