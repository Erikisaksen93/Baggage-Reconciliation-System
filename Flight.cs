using System;
using System.Collections.Generic;
using System.Text;

namespace Baggage_Reconciliation_System
{
    class Flight
    {
        private string _ident;
        private int _flightNum;
        public List<Booking> _bookings;


        public Flight(string ident, int flightNum)
        {
            _ident = ident;
            _flightNum = flightNum;
            _bookings = new List<Booking>();
        }

        public string FlightInfo()
        {
            var output = "";
            
            for (int i = 0; i < _bookings.Count; i++)
            {
                var bookedPassenger = _bookings[i]._passenger;
                var bookedFlight = _bookings[i]._flight;
                var bookedBag = _bookings[i]._bag;
                output += string.Format("Name: {0} {1} {2}{3}, Bag: {4}\n", bookedPassenger._firstName, bookedPassenger._lastName, bookedFlight._ident, bookedFlight._flightNum, bookedBag.GetBagInfo());
            }

            return output;
        }

    }
}
