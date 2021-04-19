using System;
using System.Collections.Generic;

namespace Baggage_Reconciliation_System
{
    class Program
    {
        static void Main(string[] args)
        {

            var erik = new Passenger("Erik", "Isaksen");
            var joakim = new Passenger("Joakim", "Schrøder");
            var fr6032 = new Flight("FR", 6032);
            var eriksinbag = new Bag(23f, "FR54235");
            var joakimsinbag = new Bag(3452f, "FR54225");

            //erik._bag = eriksinbag;
            //joakim._bag = joakimsinbag;


            

            var booking1 = new Booking(erik, eriksinbag, fr6032);
            var booking2 = new Booking(joakim, joakimsinbag, fr6032);

            //fr6032._bookings = new List<Booking>();
            fr6032._bookings.Add(booking1);
            fr6032._bookings.Add(booking2);

            Console.WriteLine(fr6032.FlightInfo());

            //for (int i = 0; i < fr6032._bookings.Count; i++)
            //{
            //    Console.WriteLine(fr6032._bookings[i]._passenger._firstName);
            //}




        }
    }
}
