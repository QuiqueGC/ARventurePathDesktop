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
    
    public partial class user
    {
        public user()
        {
            this.achievement = new HashSet<achievement>();
            this.arventure = new HashSet<arventure>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string passwd { get; set; }
        public string img { get; set; }
        public Nullable<double> distance { get; set; }
        public int steps { get; set; }
    
        public virtual ICollection<achievement> achievement { get; set; }
        public virtual ICollection<arventure> arventure { get; set; }
    }
}
