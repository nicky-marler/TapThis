using System;
using System.Collections.Generic;
using System.Text;

namespace TapThis.Model
{
    public class Geo_Point
    {
        public double Longitude { get; private set; }
        public double Latitude { get; private set; }

        public Geo_Point(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
