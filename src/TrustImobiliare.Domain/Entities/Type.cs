using System.Collections.Generic;

namespace TrustImobiliare.Domain.Entities
{
    public class Type
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
        public List<Property> Properties { get; set; } = new List<Property>();
    }
}