using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    [TestClass]
    public class ServiceEventTest
    {
        [TestMethod]
        public void AddDeleteEventTest()
        {
            EventCRUD eventService = new EventCRUD(new TestDataLayerAPI());

            eventService.AddEvent(1,1, new DateTime(2001, 01, 01));

            Assert.AreEqual(eventService.GetEvent(1).ClientID, 1);

            eventService.DeleteEvent(1);
        }

        [TestMethod]
        public void UpdateEventTest()
        {
            EventCRUD eventService = new EventCRUD(new TestDataLayerAPI());

            eventService.AddEvent(1, 1, new DateTime(2001, 01, 01));
            eventService.UpdateEventClient(1, 2);

            Assert.AreEqual(eventService.GetEvent(1).ClientID, 2);

            eventService.DeleteEvent(1);
        }

        [TestMethod]
        public void GetEventsTest()
        {
            EventCRUD eventService = new EventCRUD(new TestDataLayerAPI());

            Assert.AreEqual(eventService.GetAllEvents().Count(), 0);
        }
    }
}
