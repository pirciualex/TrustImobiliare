namespace TrustImobiliare.Domain.Entities
{
    public class Type
    {
        public int TypeId { get; set; }
        public int PropertyId { get; set; }
        public string Name { get; set; }
        public Property Property { get; set; }
    }
}