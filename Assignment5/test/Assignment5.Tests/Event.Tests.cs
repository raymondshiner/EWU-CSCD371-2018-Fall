using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment5.Tests
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void Event_CreateDefaultEvent_DefaultValuesAreCorrect()
        {
            var myEvent = new Event();

            Assert.AreEqual("Event", myEvent.Name);
            Assert.AreEqual("Seattle", myEvent.Location);
            Assert.AreEqual("Event@Seattle", myEvent.Title);
            Assert.AreEqual("12:00pm - 1:00pm", myEvent.Time);
        }

        [TestMethod]
        public void Event_CreateEventNameLocationTimeValid_ValuesAreCorrect()
        {
            var myEvent = new Event("Party", "MyPlace", "8:00pm - 12:00am");

            Assert.AreEqual("Party", myEvent.Name);
            Assert.AreEqual("MyPlace", myEvent.Location);
            Assert.AreEqual("Party@MyPlace", myEvent.Title);
            Assert.AreEqual("8:00pm - 12:00am", myEvent.Time);
        }

        [TestMethod]
        public void Event_CreateEventAllDataNull_DefaultValuesAreCorrect()
        {
            var myEvent = new Event(null, null, null);

            Assert.AreEqual("Event", myEvent.Name);
            Assert.AreEqual("Seattle", myEvent.Location);
            Assert.AreEqual("Event@Seattle", myEvent.Title);
            Assert.AreEqual("12:00pm - 1:00pm", myEvent.Time);
        }

        [TestMethod]
        public void Event_CreateEventAllDataEmpty_DefaultValuesAreCorrect()
        {
            var myEvent = new Event("", "", "");

            Assert.AreEqual("Event", myEvent.Name);
            Assert.AreEqual("Seattle", myEvent.Location);
            Assert.AreEqual("Event@Seattle", myEvent.Title);
            Assert.AreEqual("12:00pm - 1:00pm", myEvent.Time);
        }

        [TestMethod]
        public void Event_ManuallySetValue_ValuesAreCorrect()
        {
            var myEvent = new Event("", "", "");

            myEvent.Name = "Movie Night";
            myEvent.Location = "The Quad";
            myEvent.Time = "Midnight";

            Assert.AreEqual("Movie Night", myEvent.Name);
            Assert.AreEqual("The Quad", myEvent.Location);
            Assert.AreEqual("Movie Night@The Quad", myEvent.Title);
            Assert.AreEqual("Midnight", myEvent.Time);
        }
    }
}
