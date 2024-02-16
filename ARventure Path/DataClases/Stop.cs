using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ARventure_Path.DataClases
{
    public class Stop
    {
        private static int lastID = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }


        public Stop(string name, double longitude, double latitude )
        {
            Id = ++lastID;
            Name = name;
            Longitude = longitude;
            Latitude = latitude;
        }

    }
    
}
