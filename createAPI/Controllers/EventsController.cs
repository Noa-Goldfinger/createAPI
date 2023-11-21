using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace createAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        static List<Event> events = new List<Event> { new Event(new DateTime(2023, 09, 07)), new Event(new DateTime(2023, 09, 08)), new Event(new DateTime(2023, 09, 09)) };
        // GET: api/<EventController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(events);
        }

        // POST api/<EventController>
        [HttpPost]
        public ActionResult Post([FromBody] Event newEvent)
        {
            if (newEvent == null)
                return NotFound();
            newEvent.Id = ++Event.IndexId;
            events.Add(newEvent);
            return Ok();
        }


        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Event updateEvent)
        {
            var eve = events.Find(e => e.Id == id);
            if (eve == null)
                return NotFound();
            eve.Title = updateEvent.Title;
            eve.Start = updateEvent.Start;
            eve.End = updateEvent.End;
            return Ok();
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var eve = events.Find(e => e.Id == id);
            if (eve == null)
                return NotFound();
            events.Remove(eve);
            return Ok();
        }
    }
}
