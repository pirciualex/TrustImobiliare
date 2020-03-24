using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TrustImobiliare.Application.Properties.Dtos;
using TrustImobiliare.Domain.Entities;
using TrustImobiliare.Persistance;

namespace TrustImobiliare.Application.Properties.Commands.CreateProperty
{
    public class CreatePropertyHandler:IRequestHandler<CreatePropertyCommand,PropertyDetailDto>
    {
        private readonly TrustImobiliareDbContext _context;
        private readonly IMapper _mapper;

        public CreatePropertyHandler(TrustImobiliareDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PropertyDetailDto> Handle(CreatePropertyCommand request, CancellationToken cancellationToken)
        {
            var propertyToAdd = _mapper.Map<Property>(request);
            propertyToAdd.Type = await _context.Types.FindAsync(request.TypeId);
            propertyToAdd.Agent = await _context.Agents.FindAsync(request.AgentId);
            await _context.Properties.AddAsync(propertyToAdd);
            await _context.SaveChangesAsync();
            var propertyToReturn = _mapper.Map<PropertyDetailDto>(propertyToAdd);
            return propertyToReturn;
        }
    }
}