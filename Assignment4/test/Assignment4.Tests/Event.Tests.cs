using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment4.Tests
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void Event_MakeNewEvent_ReturnTrue()
        {
            var myEvent = new Event("Event1", "300", "Eastern Washington University");

            Assert.AreEqual("Event1", myEvent.Name);
            Assert.AreEqual("300", myEvent.StartTime);
            Assert.AreEqual("Eastern Washington University", myEvent.Location);
        }
    }
}
