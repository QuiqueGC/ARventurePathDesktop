using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.DataClases
{
    internal class Route
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Stop> Stops { get; set; }
        public DateTime Time { get; set; }
        public int Steps { get; set; }
        public float Distance { get; set; }
    }
}
