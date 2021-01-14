using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetlat
{
    class Meetlat
    {
        private double lengteInMeter;

        public Meetlat(double meterInput)
        { lengteInMeter = meterInput; }
        public Meetlat() { }

        public double BeginLengte
        {
            get { return lengteInMeter; }
            set { lengteInMeter = value; }
        }

        public double LengteInM
        {
            get { return lengteInMeter; }
        }

        public double LengteInCm
        {
            get { return lengteInMeter * 100; }
        }

        public double LengteInKm
        {
            get { return lengteInMeter / 1000; }
        }

        public double LengteInVoet
        {
            get { return lengteInMeter * 3.2808; }
        }
    }
}
