using MediatR;
using TrustImobiliare.Application.Properties.Dtos;

namespace TrustImobiliare.Application.Properties.Queries.GetPropertyDetail
{
    public class GetPropertyDetailQuery : IRequest<PropertyDetailDto>
    {
        public int Id { get; }

        public GetPropertyDetailQuery(int id)
        {
            Id = id;
        }
    }
}