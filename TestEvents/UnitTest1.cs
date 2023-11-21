using createAPI;
using createAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestEvents
{
    public class UnitTest1
    {

        [Fact]
        public void GetTest_returnOkObjectResult()
        {
            var controller = new EventsController();

            var result = controller.Get();

            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void PostTest_returnOkResult()
        {
            var controller = new EventsController();
            Event @event = new Event();
            var result = controller.Post(@event);
            Assert.IsType<OkResult>(result);
        }
        [Fact]
        public void PutTest_returnOkResult()
        {
            var controller = new EventsController();
            int id = 1;
            Event @event = new Event();
            var result = controller.Put(id, @event);
            Assert.IsType<OkResult>(result);
        }
        [Fact]
        public void DeleteTest_returnOkResult()
        {
            var controller = new EventsController();
            int id = 1;
            var result = controller.Delete(id);
            Assert.IsType<OkResult>(result);
        }
    }
}