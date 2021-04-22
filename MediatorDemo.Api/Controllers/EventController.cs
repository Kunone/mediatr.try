using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatorDemo.Library.Commands;
using MediatorDemo.Library.Models;
using MediatorDemo.Library.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatorDemo.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EventController : Controller
    {
        private readonly IMediator _mediator;

        public EventController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<DemoEvent>> GetAllEvents() => await _mediator.Send(new GetAllEventsQuery());

        [HttpGet("{id}")]
        public async Task<DemoEvent> GetEventById(int id) => await _mediator.Send(new GetEventByIdQuery(id));

        [HttpPost]
        public async Task<DemoEvent> CreateEvent([FromBody] DemoEvent viewModel) => await _mediator.Send(new CreateEventCommand(viewModel.Start, viewModel.End));
    }
}
