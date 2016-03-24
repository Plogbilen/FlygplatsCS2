using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlygplatsCS2
{
    class Flight
    {
        Random rnd = new Random();

        private String _flightnumber;
        private int _numberOfPassengers;
        private int _fuelLevel;

        public Flight()
        {
            _fuelLevel = rnd.Next(0, 11);
            _flightnumber = RandomString(8);
        }

        

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

        public bool hasCrashed()
        {
            if (rnd.Next(0, 241) == 0)
                return true;
            return false;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void updateFuelLevels()
        {
            _fuelLevel--;
        }

    }
}
