using System;
using System.Collections.Generic;
using System.Linq;
using MediatorDemo.Library.Models;

namespace MediatorDemo.Library.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<DemoEvent> availableEvents = new();

        public DemoDataAccess()
        {
            availableEvents.Add(new DemoEvent { Id = 1, Start = DateTime.UtcNow, End = DateTime.UtcNow.AddHours(1) });
            availableEvents.Add(new DemoEvent { Id = 2, Start = DateTime.UtcNow.AddDays(1), End = DateTime.UtcNow.AddDays(1).AddHours(1) });
        }

        public List<DemoEvent> GetEvents()
        {
            return availableEvents;
        }

        public DemoEvent AddEvent(DateTime start, DateTime end)
        {
            var demoEvent = new DemoEvent { Start = start, End = end };
            availableEvents.Add(demoEvent);
            demoEvent.Id = availableEvents.Max(e => e.Id) + 1;
            return demoEvent;
        }
    }
}
