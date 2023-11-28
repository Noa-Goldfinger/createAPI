using createAPI;
using createAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestEvents
{
    public class UnitTest1
    { 
                //לשאול איך אפש לעדכן ולהוסיף אם זה לקריאה בלבד
        private readonly EventsController _eventsController;

        public EventsControllerTest()
        {
            var context = new DataContextFake();
            _eventsController = new EventsController(context);
        }
        [Fact]
        public void GetTest_returnOkObjectResult()
        {

            var result = _eventsController.Get();

            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void PostTest_returnOkResult()
        {
            Event @event = new Event();
            var result = _eventsController.Post(@event);
            Assert.IsType<OkResult>(result);
        }
        [Fact]
        public void PutTest_returnOkResult()
        {
            int id = 1;
            Event @event = new Event();
            var result = _eventsController.Put(id, @event);
            Assert.IsType<OkResult>(result);
        }
        [Fact]
        public void DeleteTest_returnOkResult()
        {
            int id = 1;
            var result = _eventsController.Delete(id);
            Assert.IsType<OkResult>(result);
        }
    }
}