﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crud
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class crudDbEntities1 : DbContext
    {
        public crudDbEntities1()
            : base("name=crudDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CustomerTb> CustomerTb { get; set; }
        public virtual DbSet<OrderProductTb> OrderProductTb { get; set; }
        public virtual DbSet<OrdersTb> OrdersTb { get; set; }
        public virtual DbSet<ProductTb> ProductTb { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}