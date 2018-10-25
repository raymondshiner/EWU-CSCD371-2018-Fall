using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment5.Tests
{
    [TestClass]
    public class UniversityCourseTests
    {
        [TestMethod]
        public void UniversityCourse_CreateDefaultUniversityCourse_DefaultValuesAreCorrect()
        {
            var myUniCourse = new UniversityCourse();

            Assert.AreEqual("Elective Course", myUniCourse.Name);
            Assert.AreEqual("Eastern Washington University", myUniCourse.Location);
            Assert.AreEqual("TBD", myUniCourse.Schedule);
            Assert.AreEqual(5, myUniCourse.Credits);
        }

        
    }
}
