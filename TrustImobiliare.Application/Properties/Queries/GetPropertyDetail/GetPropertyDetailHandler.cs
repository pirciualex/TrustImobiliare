using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TrustImobiliare.Application.Properties.Dtos;
using TrustImobiliare.Persistance;

namespace TrustImobiliare.Application.Properties.Queries.GetPropertyDetail
{
    public class GetPropertyDetailHandler : IRequestHandler<GetPropertyDetailQuery, PropertyDetailDto>
    {
        private readonly TrustImobiliareDbContext _context;
        private readonly IMapper _mapper;

        public GetPropertyDetailHandler(TrustImobiliareDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PropertyDetailDto> Handle(GetPropertyDetailQuery request, CancellationToken cancellationToken)
        {
            var property = await _context.Properties.FindAsync(request.Id);
            var propertyResponse = _mapper.Map<PropertyDetailDto>(property);
            return propertyResponse;
        }
    }
}