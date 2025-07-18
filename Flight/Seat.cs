using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    internal class Seat
    {
        public enum SeatClass
        {
            Economy,
            Business,
            FirstClass
        }

        public int SeatNumber   { get; set; }
        public SeatClass Seatclass { get; set; }
        public bool Avilability { get; set; }
        public Seat(int seatnum , SeatClass SeatClass , bool av ) {
        SeatNumber = seatnum;
        Seatclass = Seatclass;
            Avilability = av;
        }
    }
}
