using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using createAPI;

namespace TestEvents
{
    public class DataContextFake : IDataContext
    {
        public List<Event> Events { get; set; }
        public DataContextFake()
        {
            Events = new List<Event> { new Event(new DateTime(2023, 09, 07)), new Event(new DateTime(2023, 09, 08)), new Event(new DateTime(2023, 09, 09)) };
        }
    }
}
