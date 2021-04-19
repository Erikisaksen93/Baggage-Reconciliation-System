using System;
using System.Collections.Generic;
using System.Text;

namespace Baggage_Reconciliation_System
{
    class Booking
    {
        public Passenger _passenger;
        public Bag _bag;
        public Flight _flight;

        public Booking(Passenger passenger, Bag bag, Flight flight)
        {
            _passenger = passenger;
            _bag = bag;
            _flight = flight;
        }

    }
}
