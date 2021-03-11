using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_Airlines_Limited
{
    class Booking
    {
        private string date;
        private int bookingId;
        private Customer customer;
        private Flight flight;

        public Booking(int bi, Customer customer, Flight flight)
        {
            date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
            bookingId = bi;
            this.customer = customer;
            this.flight = flight;
        }
        public string getDate() { return date; }
        public int getBookingId() { return bookingId; }
        public int getCustomerId() { return customer.getId(); }
        public string getCustomerFirstName() { return customer.getFirstName(); }
        public string getCustomerLastName() { return customer.getLastName(); }
        public int getFlightNumber() { return flight.getFlightNumber(); }

        public string toString()
        {
            string s = "Date: " + date;
            s = s + "\nBooking Number: " + bookingId;
            s = s + "\nFirst Name:" + getCustomerFirstName();
            s = s + "\nLast name:" + getCustomerLastName();
            s = s + "\nFlight Number:" + getFlightNumber();
            return s;
        }
    }
}
