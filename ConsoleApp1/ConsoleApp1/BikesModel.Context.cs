﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BikeStoresEntities : DbContext
    {
        public BikeStoresEntities()
            : base("name=BikeStoresEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<brand> brands { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<stock> stocks { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<order_items> order_items { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<store> stores { get; set; }
    }
}
