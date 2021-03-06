﻿namespace TrustImobiliare.Domain.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public int PropertyId { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string AddressDetail { get; set; }
        public Property Property { get; set; }
    }
}