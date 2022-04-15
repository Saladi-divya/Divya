using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEBAPI_TASK2.Models
{
    public partial class Dept
    {
        public Dept()
        {
            Employee = new HashSet<Employee>();
        }

        public int Did { get; set; }
        public string Dname { get; set; }
        public string Dlocation { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
