using System;
using MediatorDemo.Library.Models;
using MediatR;

namespace MediatorDemo.Library.Queries
{
    public record GetEventByIdQuery(int Id) : IRequest<DemoEvent>;
}
