﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Project : BaseEntity
    {
        public string Location { get; set; }

        public virtual ICollection<DeptProject> DeptProjects { get; set; }
        //public virtual ICollection<Department> departments { get; set; }
    }
}
