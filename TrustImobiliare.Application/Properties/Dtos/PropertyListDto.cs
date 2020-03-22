namespace TrustImobiliare.Application.Properties.Dtos
{
    public class PropertyListDto
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        public int Surface { get; set; }
        public string PrimaryPhotoLink { get; set; }
        public int? Rooms { get; set; }
        public int? Bathrooms { get; set; }
        public string Type { get; set; }
        public string AgentName { get; set; }
    }
}