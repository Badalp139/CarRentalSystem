using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    [MetadataType(typeof(CarRegMetaData))]
    public partial class CarReg
    {
        public class CarRegMetaData
        {
            [DisplayName("CarNo")]
            public string Carno { get; set; }

            [DisplayName("Make")]
            public string Make { get; set; }

            [DisplayName("Model")]
            public string Model { get; set; }

            [DisplayName("Available")]
            public string Available { get; set; }
        }
    }
}