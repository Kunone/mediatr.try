using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatorDemo.Library.Models;
using MediatorDemo.Library.Queries;
using MediatR;

namespace MediatorDemo.Library.Handlers
{
    public class GetEventByIdHandler : IRequestHandler<GetEventByIdQuery, DemoEvent>
    {
        private readonly IMediator _mediator;

        public GetEventByIdHandler(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public async Task<DemoEvent> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
        {
            var allEvents = await _mediator.Send(new GetAllEventsQuery());
            var result = allEvents.FirstOrDefault(e => e.Id == request.Id);
            return result;
        }
    }
}
