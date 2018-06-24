using System.ComponentModel.DataAnnotations;

namespace Flora.Api.Models
{
    public class Arrangement
    {
        public int ArrangmentId { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public int MaterialCount { get; set; }
        public int BouquetDetailId { get; set; }
        public BouquetDetail BouquetDetail { get; set; }
    }
}