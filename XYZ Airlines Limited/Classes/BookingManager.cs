using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_Airlines_Limited
{
    class BookingManager
    {
        private static int currentBookNumber;
        private int maxNumBookings;
        private int numBookings;
        private Booking[] bookingList;

        public BookingManager(int cbn, int max)
        {
            currentBookNumber = cbn;
            maxNumBookings = max;
            numBookings = 0;
            bookingList = new Booking[max];
        }

        public bool addBooking(Customer customer, Flight flight)
        {
            if (customer.getId() != -1 && flight.getFlightNumber() != -1)
            {
                if (flight.getNumPassengers() >= flight.getMaxSeats()) { return false; }
                Booking b = new Booking(currentBookNumber, customer, flight);
                currentBookNumber++;
                bookingList[numBookings] = b;
                numBookings++;
                flight.addPassenger(customer);
                return true;
            }
            return false;
        }

        public int findCustomer(int bid)
        {
            for (int x = 0; x < numBookings; x++)
            {
                if (bookingList[x].getCustomerId() == bid)
                    return x;
            }
            return -1;
        }

        public int findFlight(int fid)
        {
            for (int x = 0; x < numBookings; x++)
            {
                if (bookingList[x].getFlightNumber() == fid)
                    return x;
            }
            return -1;
        }

        public string getBookingList()
        {
            string s = "";
            for (int x = 0; x < numBookings; x++)
            {
                s = s + bookingList[x].getDate()
                      + "\t" + bookingList[x].getBookingId()
                      + "\t" + bookingList[x].getCustomerFirstName()
                      + "\t" + bookingList[x].getCustomerLastName()
                      + "\t" + bookingList[x].getFlightNumber() + '\n';
            }
            return s;
        }
    }
}
