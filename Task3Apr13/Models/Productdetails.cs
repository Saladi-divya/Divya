using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEBAPI_TASK3.Models
{
    public partial class Productdetails
    {
        public int Pcode { get; set; }
        public string Pname { get; set; }
        public int? Unitprice { get; set; }
        public string Pdesc { get; set; }
        public string Category { get; set; }
        public int? StockinHand { get; set; }
    }
}
