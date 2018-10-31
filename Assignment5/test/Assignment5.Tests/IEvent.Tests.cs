using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment5.Tests
{
    [TestClass]
    public class IEventTests
    {
        [TestMethod]
        public void IEvent_EventIsIEvent_ReturnTrue()
        {
            Assert.IsTrue(new Event() is IEvent);
        }

        [TestMethod]
        public void IEvent_UniversityCourseIsIEvent_ReturnTrue()
        {
            Assert.IsTrue(new UniversityCourse() is IEvent);
        }

        public void IEvent_GetLengthOfNameOnEvent_ReturnsExpectedString()
        {
            Event myEvent = new Event();
            myEvent.Name = "Phillip"; //7 chars
            var str = myEvent.GetLengthOfName();

            Assert.AreEqual(str, "Name is 7 Characters Long");
        }

        public void IEvent_GetLengthOfNameOnUniversityCourse_ReturnsExpectedString()
        {
            Event myEvent = new Event();
            myEvent.Name = "Roy"; //7 chars
            var str = myEvent.GetLengthOfName();

            Assert.AreEqual(str, "Name is 3 Characters Long");
        }
    }
}