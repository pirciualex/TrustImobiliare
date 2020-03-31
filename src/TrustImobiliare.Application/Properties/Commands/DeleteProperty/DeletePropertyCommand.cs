using MediatR;

namespace TrustImobiliare.Application.Properties.Commands.DeleteProperty
{
    public class DeletePropertyCommand : IRequest<bool>
    {
        public int PropertiId { get; set; }
    }
}