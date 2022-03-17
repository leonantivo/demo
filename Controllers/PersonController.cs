using DataLibrary.Commands;
using DataLibrary.Model;
using DataLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("person")]
        public async Task<IActionResult> GetPersons()
        {
            var response = await mediator.Send(new GetAllPerson());
            return response == null ? NotFound() : Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonById(int id)
        {
            var response = await mediator.Send(new GetPersonByID(id));
            return response == null ? NotFound() : Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePerson([FromBody] PersonModel person) 
        {
           var response = await mediator.Send(new CreateNewPerson(person));
            return response == null ? NotFound() : Ok(response);

        }
    }
}
