using MediatR;
using System.Collections.Generic;
using TrustImobiliare.Application.Properties.Dtos;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Application.Properties.Commands.CreateProperty
{
    public class CreatePropertyCommand : IRequest<PropertyDetailDto>
    {
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
        public IEnumerable<Feature> Features { get; set; }
        public Address Address { get; set; }
    }
}