using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    internal class Booking 
    {
        private static int _bookingCounter = 1;

        public int BookingID { get; }
        public flight Flight { get; set; }
        public Passenger Passenger { get; set; }
        public int SeatNumber { get; set; }
        public string BookingStatus { get; set; }
        public Booking(Passenger passenger, flight flight, int seatNumber, string bookingStatus)
        {
            BookingID = _bookingCounter++;
            Passenger = passenger;
            flight = flight;
            SeatNumber = seatNumber;
            BookingStatus = bookingStatus;
        }
    }
}
