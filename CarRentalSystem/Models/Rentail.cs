//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rentail
    {
        public int id { get; set; }
        public string Carid { get; set; }
        public Nullable<int> Custid { get; set; }
        public Nullable<int> Fee { get; set; }
        public Nullable<System.DateTime> Sdate { get; set; }
        public Nullable<System.DateTime> Edate { get; set; }
    }
}
