using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrustImobiliare.Application.Properties.Dtos;
using TrustImobiliare.Application.Properties.Queries.GetPropertiesList;
using TrustImobiliare.Application.Properties.Queries.GetPropertyDetail;

namespace TrustImobiliare.WebUI.Controllers
{
    [Route("api/properties")]
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

        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyDetailDto>> GetPropertyAsync(int id)
        {
            var query = new GetPropertyDetailQuery(id);
            var response = await _mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}