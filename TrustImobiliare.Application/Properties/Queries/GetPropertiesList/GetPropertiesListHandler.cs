using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TrustImobiliare.Application.Properties.Dtos;
using TrustImobiliare.Persistance;

namespace TrustImobiliare.Application.Properties.Queries.GetPropertiesList
{
    public class GetPropertiesListHandler : IRequestHandler<GetPropertiesListQuery, List<PropertyListDto>>
    {
        private readonly IMapper _mapper;
        private readonly TrustImobiliareDbContext _context;

        public GetPropertiesListHandler(TrustImobiliareDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PropertyListDto>> Handle(GetPropertiesListQuery request, CancellationToken cancellationToken)
        {
            var properties = await _context.Properties.ToListAsync();
            var propertiesResponse = _mapper.Map<List<PropertyListDto>>(properties);
            return propertiesResponse;
        }
    }
}