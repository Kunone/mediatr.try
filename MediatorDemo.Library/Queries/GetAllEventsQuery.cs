using System.Collections.Generic;
using MediatorDemo.Library.Models;
using MediatR;

namespace MediatorDemo.Library.Queries
{
    public record GetAllEventsQuery : IRequest<List<DemoEvent>>;
}
