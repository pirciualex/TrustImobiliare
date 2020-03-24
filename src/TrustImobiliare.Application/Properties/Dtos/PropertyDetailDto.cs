using System.Collections.Generic;

namespace TrustImobiliare.Application.Properties.Dtos
{
    public class PropertyDetailDto
    {
        public int PropertyId { get; set; }
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
        public string Address { get; set; }
        public string Type { get; set; }
        public IEnumerable<FeatureDto> Features { get; set; } = new List<FeatureDto>();
        public AgentDto Agent { get; set; }
    }
}