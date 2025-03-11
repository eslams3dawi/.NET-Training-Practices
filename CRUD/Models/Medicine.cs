using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaCare.Models
{
    public class Medicine
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public decimal MedicinePrice { get; set; }
        public bool BulkAllowed { get; set; }
        public int QuantityInStock { get; set; }
        public bool PrescriptionRequired { get; set; }
        public DateTime ExpiryDate { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
