using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment9.Tests
{
    [TestClass]
    public class PatentDataAnalyzerTests
    {
        [TestMethod]
        public void InventorNames_USA_ReturnsExpectedList()
        {
            List<string> expectedList = new List<string>();
            expectedList.Add("Benjamin Franklin");
            expectedList.Add("Orville Wright");
            expectedList.Add("Wilbur Wright");
            expectedList.Add("Samuel Morse");
            expectedList.Add("John Michaelis");
            expectedList.Add("Mary Phelps Jacob");

            List<string> actualList = PatentDataAnalyzer.InventorNames("USA");

            for (int x = 0; x < expectedList.Count; x++)
            {
                Assert.AreEqual(expectedList[x], actualList[x]);
            }

            Assert.AreEqual(expectedList.Count, actualList.Count);
        }

        [TestMethod]
        public void InventorNames_NullInput_ReturnsEmptyList()
        {
            List<string> actualList = PatentDataAnalyzer.InventorNames(null);
            Assert.AreEqual(actualList.Count, 0);
        }

        [TestMethod]
        public void InventorLastNames_ReturnsExpectedLastNames()
        {
            var expectedOutput = new List<string>();
            expectedOutput.Add("Jacob");
            expectedOutput.Add("Michaelis");
            expectedOutput.Add("Stephenson");
            expectedOutput.Add("Morse");
            expectedOutput.Add("Wright");
            expectedOutput.Add("Wright");
            expectedOutput.Add("Franklin");

            var actualOutput = new List<string>(PatentDataAnalyzer.InventorLastNames());

            for(int x = 0; x < expectedOutput.Count; x++)
            {
                Assert.AreEqual(expectedOutput[x], actualOutput[x]);
            }

            Assert.AreEqual(expectedOutput.Count, actualOutput.Count);
        }

        [TestMethod]
        public void Randomize_RandomizesOrderThreeTimesOver()
        {
            IEnumerable<Inventor> randomList = PatentData.Inventors.Randomize();
            IEnumerable<Inventor> prevList = new List<Inventor>();

            for (int x = 0; x < 3; x++)
            {
                Assert.IsFalse(randomList.SequenceEqual(PatentData.Inventors)); //check list against orignial
                Assert.IsFalse(prevList.SequenceEqual(randomList)); //check list against previous version
                prevList = randomList; //keep track of current random order
                randomList = randomList.Randomize(); //make new random order
            }
        }

        [TestMethod]
        public void LocationsWithInventors_ReturnsExpectedList()
        {
            string expectedOutput = "PA-USA, NC-USA, NY-USA, Northumberland-UK, IL-USA";
            string actualOutput = PatentDataAnalyzer.LocationsWithInventors();

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}