using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.DataClases
{
     public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Summary { get; set; }
        public BindingList<string> TxtFragments { get; set; }

        public Story() 
        { 
            TxtFragments = new BindingList<string>();
        }
    }
}
