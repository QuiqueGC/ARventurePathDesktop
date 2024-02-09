using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.DataClases
{
    internal class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Summary { get; set; }
        public ArrayList TxtFragments { get; set; }
    }
}
