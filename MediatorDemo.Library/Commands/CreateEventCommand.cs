using System;
using MediatorDemo.Library.Models;
using MediatR;

namespace MediatorDemo.Library.Commands
{
    public record CreateEventCommand(DateTime start, DateTime end) : IRequest<DemoEvent>;
}
