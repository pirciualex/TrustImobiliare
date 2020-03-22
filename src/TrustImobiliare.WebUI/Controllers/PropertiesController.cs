using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrustImobiliare.Application.Properties.Dtos;
using TrustImobiliare.Application.Properties.Queries.GetPropertiesList;

namespace TrustImobiliare.WebUI.Controllers
{
    [Route("properties")]
    public class PropertiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PropertiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<PropertyListDto>>> GetPropertiesAsync()
        {
            var query = new GetPropertiesListQuery();
            var response = await _mediator.Send(query);
            return Ok(response);

        }
    }
}