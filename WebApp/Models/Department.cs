using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DeptCode { get; set; }
        public string DeptName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
