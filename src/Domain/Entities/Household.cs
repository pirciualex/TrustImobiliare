namespace TrustImobiliare.Domain.Entities
{
    public class Household:Property
    {
        public int Rooms { get; set; }
        public int Bathrooms { get; set; }
        public int Year { get; set; }
    }
}