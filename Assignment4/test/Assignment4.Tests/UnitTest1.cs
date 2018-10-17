using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment4.Tests
{
    [TestClass]
    public class UniversityCourseTests
    {
        [TestMethod] public void InstantiateCourseObject()
        {
            var course = new Course();
        }

        [TestMethod] public void setName()
        {
            var course = new Course();
            course.name = "CS 371";
        }

        [TestMethod] public void getName()
        {
            var course = new Course();
            string something = course.name;
        }
    }
}
