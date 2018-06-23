using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Flora.Api.Models
{
    public class Bouquet
    {
        public int BouquetId { get; set; }
        public string Name { get; set; }
        public ICollection<BouquetDetail> BouquetTypes { get; set; }
    }
}