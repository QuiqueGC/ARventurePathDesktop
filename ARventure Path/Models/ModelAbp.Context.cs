﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AbpEntities : DbContext
    {
        public AbpEntities()
            : base("name=AbpEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<achievement> achievement { get; set; }
        public DbSet<arventure> arventure { get; set; }
        public DbSet<fragment> fragment { get; set; }
        public DbSet<happening> happening { get; set; }
        public DbSet<route> route { get; set; }
        public DbSet<stop> stop { get; set; }
        public DbSet<story> story { get; set; }
        public DbSet<user> user { get; set; }
    }
}