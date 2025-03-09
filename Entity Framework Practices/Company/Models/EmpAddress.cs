using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class EmpAddress
    {
        public int EmpAddressId { get; set; }
        public string Address { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee employee { get; set; }
    }
}
