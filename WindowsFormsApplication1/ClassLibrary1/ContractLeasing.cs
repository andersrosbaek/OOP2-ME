//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ContractLeasing
    {
        public int LeasingID { get; set; }
        public decimal MonthlyPrice { get; set; }
        public int SENumber { get; set; }
        public int VehicleTruckID { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual CustomerBusiness CustomerBusiness { get; set; }
        public virtual VehicleTruck VehicleTruck { get; set; }
    }
}
