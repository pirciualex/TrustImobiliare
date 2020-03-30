using AutoMapper;
using TrustImobiliare.Application.Properties.Commands.CreateProperty;
using TrustImobiliare.Application.Properties.Commands.UpdateProperty;
using TrustImobiliare.Application.Properties.Dtos;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Property, PropertyListDto>()
                .ForMember(dest => dest.Type, opt =>
                    opt.MapFrom(src => src.Type.Name))
                .ForMember(dest => dest.AgentName, opt =>
                    opt.MapFrom(src => $"{src.Agent.LastName} {src.Agent.FirstName}"));

            CreateMap<Property, PropertyDetailDto>()
                .ForMember(dest => dest.Address, opt =>
                    opt.MapFrom(src => $"{src.Address.AddressDetail}, {src.Address.City}"))
                .ForMember(dest => dest.Type, opt =>
                    opt.MapFrom(src => src.Type.Name));

            CreateMap<CreatePropertyCommand, Property>();
            CreateMap<UpdatePropertyCommand, Property>();

            CreateMap<Feature, FeatureDto>();
            CreateMap<Agent, AgentDto>();
        }
    }
}