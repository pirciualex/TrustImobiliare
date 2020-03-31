using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TrustImobiliare.Persistance;

namespace TrustImobiliare.Application.Properties.Commands.DeleteProperty
{
    public class DeletePropertyHandler : IRequestHandler<DeletePropertyCommand, bool>
    {
        private readonly TrustImobiliareDbContext _context;

        public DeletePropertyHandler(TrustImobiliareDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeletePropertyCommand request, CancellationToken cancellationToken)
        {
            var propertyToDelete = await _context.Properties.FindAsync(request.PropertiId);
            if (propertyToDelete == null)
            {
                return false;
            }

            _context.Properties.Remove(propertyToDelete);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}