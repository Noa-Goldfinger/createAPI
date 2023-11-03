using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace createAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        static List<Event> events = new List<Event>{ new Event(new DateTime(2023, 09, 07)), new Event(new DateTime(2023, 09, 08)) , new Event(new DateTime(2023, 09, 09) ) };
        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return events;
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            events.Add(new Event(newEvent.Title,newEvent.Start,newEvent.End));
        }


        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event updateEvent)
        {
            var eve = events.Find(e => e.Id == id);
            eve.Title = updateEvent.Title;
            eve.Start = updateEvent.Start;
            eve.End = updateEvent.End;
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve = events.Find(e => e.Id == id);
            events.Remove(eve);
        }
    }
}
