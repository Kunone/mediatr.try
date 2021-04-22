using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatorDemo.Library.DataAccess;
using MediatorDemo.Library.Models;
using MediatorDemo.Library.Queries;
using MediatR;

namespace MediatorDemo.Library.Handlers
{
    public class GetAllEventsHandler : IRequestHandler<GetAllEventsQuery, List<DemoEvent>>
    {
        private readonly IDataAccess _dataAccess;

        public GetAllEventsHandler(IDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public Task<List<DemoEvent>> Handle(GetAllEventsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetEvents());
        }
    }
}
