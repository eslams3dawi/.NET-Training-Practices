using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaCare.Models
{
    public class Client : Person
    {
        public DateTime BirthDate { get; set; }
        public int ClientAge { get; set; }
        public bool IsVendor { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
