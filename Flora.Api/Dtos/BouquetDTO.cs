using System.Collections.Generic;

namespace Flora.Api.Dtos
{
    public class BouquetDTO
    {
        public string Name { get; set; }
        public ICollection<BouquetDetailDTO> BouquetTypes { get; set; }
    }
}