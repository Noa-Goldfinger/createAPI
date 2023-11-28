using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace createAPI
{
    public class DataContext:IDataContext
    {
        public List<Event> Events { get; set; }
        public DataContext()
        {
            Events = new List<Event> { new Event(new DateTime(2023, 09, 07)), new Event(new DateTime(2023, 09, 08)), new Event(new DateTime(2023, 09, 09)) };
        }
    }
}
