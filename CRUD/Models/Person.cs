using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaCare.Models
{
    public abstract class Person 
    {
        public int Id { get; set; }
        public string HashPassword { get; set; }
        public string FName { get; set; }
        public string? LName { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
    }
}
