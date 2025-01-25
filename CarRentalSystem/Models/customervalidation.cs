using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public partial class Customer
    {
        [MetadataType(typeof(CustomerMetaData))]
        public class CustomerMetaData
        {
            [DipalyName("CustoMerName")]

            public string CustName { get; set; }

            [DipalyName("Address")]
            public string Address { get; set; }

            [DipalyName("Mobile")]
            public Nullable<int> Mobile { get; set; }
        }
        
    }
}