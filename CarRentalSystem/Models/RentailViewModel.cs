using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class RentailViewModel
    {
        public int id { get; set; }
        public string Carid { get; set; }
        public Nullable<int> Custid { get; set; }
        public Nullable<int> Fee { get; set; }
        public Nullable<System.DateTime> Sdate { get; set; }
        public Nullable<System.DateTime> Edate { get; set; }
        public string Available { get; set; }







    }
}