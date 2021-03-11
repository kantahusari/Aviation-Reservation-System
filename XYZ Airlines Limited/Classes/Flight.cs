﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_Airlines_Limited
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] passengers;

        public Flight(int fn, string or, string dest, int mSeats)
        {
            maxSeats = mSeats;
            flightNumber = fn;
            origin = or;
            destination = dest;
            numPassengers = 0;
            passengers = new Customer[maxSeats];
        }

        public int getFlightNumber() { return flightNumber; }
        public string getOrigin() { return origin; }
        public string getDestination() { return destination; }
        public int getMaxSeats() { return maxSeats; }
        public int getNumPassengers() { return numPassengers; }

        public bool addPassenger(Customer c)
        {
            if (numPassengers < maxSeats)
            {
                passengers[numPassengers] = c;
                numPassengers++;
                return true;
            }
            return false;
        }

        public int findPassenger(int custId)
        {
            for (int x = 0; x < maxSeats; x++)
            {
                if (passengers[x].getId() == custId)
                    return x;
            }
            return -1;
        }

        public bool removePassenger(int custId)
        {
            int loc = findPassenger(custId);
            if (loc == -1) return false;
            passengers[loc] = passengers[numPassengers - 1];
            numPassengers--;
            return true;
        }

        public string getPassengerList()
        {
            string s = "\r\nPassengers on Flight: " + flightNumber;
            for (int x = 0; x < numPassengers; x++)
            {
                s = s + "\r\n" + passengers[x].getFirstName() + " " + passengers[x].getLastName();
            }
            return s;
        }

        public string toString()
        {
            string s = "Flight Number: " + flightNumber;
            s = s + "\r\nOrigin: " + origin;
            s = s + "\r\nDestination: " + destination;
            s = s + "\r\nNumber of Passengers: " + numPassengers;
            s = s + "\r\nAvailable Seats: " + (maxSeats - numPassengers);
            s = s + getPassengerList();
            return s;
        }
    }
}
