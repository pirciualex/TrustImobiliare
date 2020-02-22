using System.Collections.Generic;

namespace TrustImobiliare.Domain.Entities
{
    public abstract class Property
    {
        protected Property()
        {
            Features = new List<Feature>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        public int Surface { get; set; }
        public string PrimaryPhotoLink { get; set; }
        public string PhotoLinks { get; set; }
        public IEnumerable<Feature> Features { get; private set; }
        public int TypeId { get; set; }
        public int AddressId { get; set; }
        public int AgentId { get; set; }
    }
}