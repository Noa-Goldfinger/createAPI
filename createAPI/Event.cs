using System.ComponentModel;
using System.Text.Json.Serialization;

namespace createAPI
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public static int IndexId { get; set; }
        public Event(string title, DateTime start, DateTime end)
        {
            Id = ++IndexId;
            Title = title;
            Start = start;
            End = end;
        }
        public Event(DateTime start)
        {
            Id = ++IndexId;
            Start = start;
        }

        public Event()
        {
           
        }
    }
}
