using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEBAPI_TASK3.Models
{
    public partial class Person
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int? Age { get; set; }
        public string PGender { get; set; }
    }
}
