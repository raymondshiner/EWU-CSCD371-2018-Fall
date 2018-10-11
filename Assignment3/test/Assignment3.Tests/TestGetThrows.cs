using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Assignment3.Tests
{
    [TestClass]
    public class TestGetThrows
    {
        [TestMethod]
        public void ReturnsRockRock()
        {
            (string cpuThrow, string userThrow) throws = ("rock", "rock");

            Assert.AreEqual(throws, RoshamboMethods.GetThrows());
        }
    }
}
