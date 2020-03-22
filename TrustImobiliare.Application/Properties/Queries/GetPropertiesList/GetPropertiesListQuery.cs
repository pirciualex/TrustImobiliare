using System.Collections.Generic;
using MediatR;
using TrustImobiliare.Application.Properties.Dtos;

namespace TrustImobiliare.Application.Properties.Queries.GetPropertiesList
{
    public class GetPropertiesListQuery:IRequest<List<PropertyListDto>>
    {
        
    }
}