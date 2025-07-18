using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    internal class Ticket
    {
        public int TicketNumber { get; set; }
        public decimal Fare { get; set; }
        public bool IsActive { get; set; }
        public Booking Booking { get; set; }

        public Ticket(int ticketnum , decimal fare , bool isactive ) { 
        TicketNumber = ticketnum;
            Fare = fare;
            IsActive = isactive;
        }
    }
}
