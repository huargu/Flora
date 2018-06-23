using System.Collections.Generic;

namespace Flora.Api.Models
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }

        public ICollection<MaterialSpecification> MaterialSpecifications { get; set; }
    }
}