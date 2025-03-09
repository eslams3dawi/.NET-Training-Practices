using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class DeptProject
    {
        public int ProjId { get; set; }
        public virtual Project project { get; set; }
        public int DeptId { get; set; }
        public virtual Department department { get; set; }

        public DateTime Date { get; set; }
    }
}
