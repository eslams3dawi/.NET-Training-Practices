using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    //[Index(nameof(Salary), Name = "SalaryIndex")]
    public class Employee : BaseEntity
    {
        public decimal Salary { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department department { get; set; }

        public int AddressId { get; set; }
        public virtual EmpAddress address { get; set; }
    }
}
