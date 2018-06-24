using System.Collections.Generic;

namespace Flora.Api.Models
{
    public class Specification
    {
        public int SpecificationId { get; set; }
        public string Name { get; set; }

        //public ICollection<MaterialSpecification> MaterialSpecifications { get; set; }
    }
}