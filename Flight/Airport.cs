using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    internal class Airport
    {
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
        public string Location { get; set; }
        public Airport(string airportcode , string airportname , string location) {
            AirportCode = airportcode;
            AirportName = airportname;
            Location = location;
        }
    }
}
