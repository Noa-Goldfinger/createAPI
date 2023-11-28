using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace createAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
         IDataContext _dataContext;
        public EventsController(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        // GET: api/<EventController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_dataContext.Events);
        }

        // POST api/<EventController>
        [HttpPost]
        public ActionResult Post([FromBody] Event newEvent)
        {
            if (newEvent == null)
                return NotFound();
            newEvent.Id = ++Event.IndexId;
            _dataContext.Events.Add(newEvent);
            return Ok();
        }


        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Event updateEvent)
        {
            var eve = _dataContext.Events.Find(e => e.Id == id);
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
            var eve = _dataContext.Events.Find(e => e.Id == id);
            if (eve == null)
                return NotFound();
            _dataContext.Events.Remove(eve);
            return Ok();
        }
    }
}
