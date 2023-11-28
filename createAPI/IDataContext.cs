using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace createAPI
{
    public interface IDataContext
    {
        public List<Event> Events { get; set; }
    }
}
