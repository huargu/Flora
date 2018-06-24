using System.Collections.Generic;

namespace Flora.Api.Dtos
{
    public class BouquetDetailDTO
    {
        public string Size { get; set; }
        public decimal Price { get; set; }
        public ICollection<ArrangementDTO> Materials { get; set; }
    }
}