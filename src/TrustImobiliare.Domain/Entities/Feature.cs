namespace TrustImobiliare.Domain.Entities
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int PropertyId { get; set; }
    }
}