using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlygplatsCS2
{
    class Flight
    {
        private String _flightnumber;
        private int _numberOfPassengers;
        private int _fuelLevel;

        public string Name
        {
            get { return _flightnumber; }
            set { _flightnumber = value; }
        }

        public int numberOfPassengers
        {
            get { return _numberOfPassengers; }
            set { _numberOfPassengers = value; }
        }

        public int fuelLevel
        {
            get { return _fuelLevel; }
            set { _fuelLevel = value; }
        }
    }
}
