using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEBAPI_TASK3.Models
{
    public partial class Regdetails
    {
        public int Rid { get; set; }
        public string Firstname { get; set; }
        public string Mailid { get; set; }
        public int? Contact { get; set; }
        public string Experience { get; set; }
        public string Skillset { get; set; }
    }
}
