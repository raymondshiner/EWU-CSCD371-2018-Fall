using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment5.Tests
{
    [TestClass]
    public class GatheringTests
    {
        [TestInitialize]
        public void SetupTests()
        {
            Gathering.ResetInstantiationCount();
        }

        [TestMethod]
        public void Gathering_Create3DefaultGatherings_InstantiationCountIs3()
        {
            var myGathering = new Gathering();
            var myGathering2 = new Gathering();
            var myGathering3 = new Gathering();

            Assert.AreEqual(3, Gathering.InstantiationCount);
        }

        [TestMethod]
        public void Gathering_CreateDefaultGathering_DefaultNameIsGathering()
        {
            var myGathering = new Gathering();
            
            Assert.AreEqual("Gathering", myGathering.Name);
        }

        [TestMethod]
        public void Gathering_CreateDefaultGathering_DefaultLocationIsSeattle()
        {
            var myGathering = new Gathering();

            Assert.AreEqual("Seattle", myGathering.Location);
        }

        

        [TestMethod]
        public void Gathering_CreateGatheringWithNameAndLocation_NameAndLocationCorrect()
        {
            var myGathering = new Gathering("Party", "MyHouse");

            Assert.AreEqual("Party", myGathering.Name);
            Assert.AreEqual("MyHouse", myGathering.Location);
        }

        [TestMethod]
        public void Gathering_CreateGatheringNameNullLocationNull_NameAndLocationDefault()
        {
            var myGathering = new Gathering(null, null);

            Assert.AreEqual("Gathering", myGathering.Name);
            Assert.AreEqual("Seattle", myGathering.Location);
        }

        [TestMethod]
        public void Gathering_CreateGatheringNameEmptyLocationEmpty_NameAndLocationDefault()
        {
            var myGathering = new Gathering("", "");

            Assert.AreEqual("Gathering", myGathering.Name);
            Assert.AreEqual("Seattle", myGathering.Location);
        }

        [TestMethod]
        public void Gathering_ManuallySetValues_ValuesAreCorrect()
        {
            var myGathering = new Gathering();
            myGathering.Name = "Thing";
            myGathering.Location = "MyHouse";

            Assert.AreEqual("Thing", myGathering.Name);
            Assert.AreEqual("MyHouse", myGathering.Location);
        }

        public void Gathering_IsEventAGathering_ReturnTrue()
        {
            Assert.IsInstanceOfType(new Event(), typeof(Gathering));
        }
        
        public void Gathering_IsUniversityCourseAGathering_ReturnTrue()
        {
            Assert.IsInstanceOfType(new UniversityCourse(), typeof(Gathering));
        }
    }
}
