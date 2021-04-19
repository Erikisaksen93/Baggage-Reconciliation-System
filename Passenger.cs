using System;
using System.Collections.Generic;
using System.Text;

namespace Baggage_Reconciliation_System
{
    class Passenger
    {
        public string _firstName { get; }
        public string _lastName { get; }
        private Booking _booking;
        private Bag _bag;


        public Passenger(string firstName, string lastName, Booking booked = null, Bag bags = null)
        {
            _firstName = firstName;
            _lastName = lastName;
            _booking = booked;
            _bag = bags;

        }

        //public string GetName()
        //{
        //    return $"{_firstName} {_lastName}";
        //}
    }
}
