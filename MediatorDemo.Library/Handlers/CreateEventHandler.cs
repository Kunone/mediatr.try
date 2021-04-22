using System;
using System.Threading;
using System.Threading.Tasks;
using MediatorDemo.Library.Commands;
using MediatorDemo.Library.DataAccess;
using MediatorDemo.Library.Models;
using MediatR;

namespace MediatorDemo.Library.Handlers
{
    public class CreateEventHandler : IRequestHandler<CreateEventCommand, DemoEvent>
    {
        private readonly IDataAccess _dataAccess;

        public CreateEventHandler(IDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public Task<DemoEvent> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.AddEvent(request.start, request.end));
        }
    }
}
