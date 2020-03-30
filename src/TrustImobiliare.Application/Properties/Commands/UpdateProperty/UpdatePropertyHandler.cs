using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TrustImobiliare.Persistance;

namespace TrustImobiliare.Application.Properties.Commands.UpdateProperty
{
    public class UpdatePropertyHandler : IRequestHandler<UpdatePropertyCommand, bool>
    {
        private readonly TrustImobiliareDbContext _context;
        private readonly IMapper _mapper;

        public UpdatePropertyHandler(TrustImobiliareDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdatePropertyCommand request, CancellationToken cancellationToken)
        {
            var propertyToUpdate = await _context.Properties.FindAsync(request.PropertyId);
            if (propertyToUpdate == null)
            {
                return false;
            }

            propertyToUpdate.Address =
                await _context.Addresses.FirstOrDefaultAsync(a => a.PropertyId == propertyToUpdate.PropertyId);
            propertyToUpdate.Agent =
                await _context.Agents.FirstOrDefaultAsync(a => a.Properties.Contains(propertyToUpdate));
            propertyToUpdate.Features = await _context.Features.Where(f => f.PropertyId == propertyToUpdate.PropertyId).ToListAsync();
            propertyToUpdate.Type = await _context.Types.FindAsync(propertyToUpdate.TypeId);

            _mapper.Map(request, propertyToUpdate);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}