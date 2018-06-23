using System.ComponentModel.DataAnnotations;

namespace Flora.Api.Models
{
    public class Arrangement
    {
        public int ArrangmentId { get; set; }
        public Material Material { get; set; }
        public int MaterialCount { get; set; }
    }
}