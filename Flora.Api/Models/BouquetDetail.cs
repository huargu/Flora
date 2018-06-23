using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Flora.Api.Models
{
    public class BouquetDetail
    {
        public int DetailId { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public ICollection<Arrangement> Materials { get; set; }
    }
}