﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutoLotEntities : DbContext
    {
        public AutoLotEntities()
            : base("AutoLotEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ContractLeasing> ContractLeasings { get; set; }
        public virtual DbSet<ContractSale> ContractSales { get; set; }
        public virtual DbSet<CustomerBusiness> CustomerBusinesses { get; set; }
        public virtual DbSet<CustomerPrivate> CustomerPrivates { get; set; }
        public virtual DbSet<VehicleCar> VehicleCars { get; set; }
        public virtual DbSet<VehicleTruck> VehicleTrucks { get; set; }
    }
}