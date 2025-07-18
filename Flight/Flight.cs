using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    internal class flight
    {
        public int FlightNumber { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AvailableSeats { get; set; }

        public flight(int fnum,string depairport , string arriairport , DateTime deptime , DateTime arrtime , int avseats ) {
            FlightNumber = fnum;
            DepartureAirport = depairport;
            ArrivalAirport = arriairport;
            DepartureTime = deptime;
            ArrivalTime = arrtime;
            AvailableSeats = avseats;

        }
    }
}
