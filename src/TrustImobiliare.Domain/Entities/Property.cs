using System.Collections.Generic;

namespace TrustImobiliare.Domain.Entities
{
    public class Property
    {
        public int PropertyId { get; set; }
        public int AgentId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        public int Surface { get; set; }
        public string PrimaryPhotoLink { get; set; }
        public string PhotoLinks { get; set; }
        public int? Rooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? Year { get; set; }
        public virtual IEnumerable<Feature> Features { get; set; } = new List<Feature>();
        public virtual Type Type { get; set; }
        public virtual Address Address { get; set; }
        public virtual Agent Agent { get; set; }
    }
}