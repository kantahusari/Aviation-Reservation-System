using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_Airlines_Limited
{
    public class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager boManager;


        public AirlineCoordinator(int custIdSeed, int maxCust, int maxFlights)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(custIdSeed, maxCust);
            boManager = new BookingManager(custIdSeed, maxCust);
        }


        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public bool addCustomer(string fname, string lname, string phone)
        {
            return custManager.addCustomer(fname, lname, phone);
        }
        public bool addBooking(int customerId, int flightId)
        {
            if (custManager.findCustomer(customerId) != -1 && flManager.findFlight(flightId) != -1)
            {
                return boManager.addBooking(custManager.getCustomer(customerId), flManager.getFlight(flightId));
            }
            return false;
        }

        public string flightList()
        {
            return flManager.getFlightList();
        }

        public string customerList()
        {
            return custManager.getCustomerList();
        }

        public string bookingList()
        {
            return boManager.getBookingList();
        }

        public bool deleteCustomer(int id)
        {
            return custManager.deleteCustomer(id);
        }

        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }

        public string viewflight(int fnum)
        {
            return flManager.viewFlight(fnum);
        }

    }
}
