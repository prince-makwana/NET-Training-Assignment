//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBM.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblVehicle
    {
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public string ChassisNo { get; set; }
        public string Colour { get; set; }
        public double MeterValue { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public int CustomerId { get; set; }
    
        public virtual tblCustomer tblCustomer { get; set; }
    }
}