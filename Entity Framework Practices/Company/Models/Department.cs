using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Department : BaseEntity
    {
        public virtual ICollection<Employee> employees { get; set; }
        public virtual ICollection<DeptProject> DeptProjects { get; set; }
        //public virtual ICollection<Project> projects { get; set; }
    }
}
