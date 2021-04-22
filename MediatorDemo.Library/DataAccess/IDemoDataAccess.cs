using System;
using System.Collections.Generic;
using MediatorDemo.Library.Models;

namespace MediatorDemo.Library.DataAccess
{
    public interface IDataAccess
    {
        DemoEvent AddEvent(DateTime start, DateTime end);
        List<DemoEvent> GetEvents();
    }
}