namespace Flora.Api.Models
{
    public class MaterialSpecification
    {
        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public int SpecificationId { get; set; }
        public Specification Specification { get; set; }
    }
}