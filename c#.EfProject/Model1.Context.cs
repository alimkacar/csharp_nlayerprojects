﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace c_.EfProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TravelDbEntities : DbContext
    {
        public TravelDbEntities()
            : base("name=TravelDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Costumer> Costumer { get; set; }
        public virtual DbSet<Guide> Guide { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
    }
}
