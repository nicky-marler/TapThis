using System.Collections.Generic;
using Newtonsoft.Json;

namespace TapThis.Model
{
    public class Business
    {
        public string Business_ID { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Geo_Point Location { get; set; }
        // Wanting to move any database access to web service for security reasons. 
        public double Distance { get; set; }
        public Week Day { get; set; } = new Week();

        public Business(Geo_Point location)
        {
            //Create Geo_Point higher up and set it to here. Yay pointers
            Location = location;
        }
    }
}
