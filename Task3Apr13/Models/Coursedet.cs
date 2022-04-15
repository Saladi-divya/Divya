using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEBAPI_TASK3.Models
{
    public partial class Coursedet
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Cfee { get; set; }
        public string Cduration { get; set; }
        public int? Crollno { get; set; }
    }
}
