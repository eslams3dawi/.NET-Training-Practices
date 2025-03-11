using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaCare.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string? Comment { get; set; }
        public byte? Rating { get; set; }
        public DateTime ReviewDate { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public int MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }
    }
}
