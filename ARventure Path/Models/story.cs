//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARventure_Path.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class story
    {
        public story()
        {
            this.arventure = new HashSet<arventure>();
            this.fragment = new HashSet<fragment>();
            this.happening = new HashSet<happening>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string summary { get; set; }

        public virtual ICollection<arventure> arventure { get; set; }
        public virtual ICollection<fragment> fragment { get; set; }
        public virtual ICollection<happening> happening { get; set; }

        
    }
}
