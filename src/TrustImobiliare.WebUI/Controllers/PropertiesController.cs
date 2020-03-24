﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrustImobiliare.Application.Properties.Commands.CreateProperty;
using TrustImobiliare.Application.Properties.Dtos;
using TrustImobiliare.Application.Properties.Queries.GetPropertiesList;
using TrustImobiliare.Application.Properties.Queries.GetPropertyDetail;

namespace TrustImobiliare.WebUI.Controllers
{
    [ApiController]
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

        [HttpGet("{id}", Name = "GetProperty")]
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

        [HttpPost]
        public async Task<ActionResult<PropertyDetailDto>> PostPropertyAsync([FromBody] CreatePropertyCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtRoute("GetProperty", new { propertyId = response.PropertyId }, response);
        }
    }
}