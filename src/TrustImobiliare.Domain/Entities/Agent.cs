using System.Collections.Generic;

namespace TrustImobiliare.Domain.Entities
{
    public class Agent
    {
        public int AgentId { get; set; }
        public int PropertyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoLink { get; set; }
        public List<Property> Properties { get; set; }
    }
}