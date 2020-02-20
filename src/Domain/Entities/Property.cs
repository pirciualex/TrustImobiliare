using System.Collections.Generic;

namespace Domain.Entities
{
    public abstract class Property
    {
        protected Property()
        {
            PhotoLinks = new List<string>();
            Features = new Dictionary<string, string>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        public int Surface { get; set; }
        public string PrimaryPhotoLink { get; set; }
        public List<string> PhotoLinks { get; private set; }
        public Dictionary<string,string> Features { get; private set; }
        public int TypeId { get; set; }
        public int AgentId { get; set; }
    }
}