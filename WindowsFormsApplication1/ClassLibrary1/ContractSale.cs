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
    
    public partial class ContractSale
    {
        public int SalesID { get; set; }
        public int CustomerPrivateID { get; set; }
        public int VehicleCarID { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual CustomerPrivate CustomerPrivate { get; set; }
        public virtual VehicleCar VehicleCar { get; set; }
    }
}
