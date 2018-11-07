using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment6.Tests
{
    [TestClass]
    public class MyEnumsTests
    {
        [TestMethod]
        public void AddWeekDays_AddMondayToEnums_ReturnsTrue()
        {
            MyEnums.Schedule mySchedule = new MyEnums.Schedule();

            MyEnums.AddWeekDays("Monday", mySchedule.DaysOfWeek);

            Assert.IsTrue(((mySchedule.DaysOfWeek & MyEnums.WeekDays.Monday) != 0));
        }

        [TestMethod]
        public void AddWeekDaysm_AddTuesdayAndThursdayToEnums_ReturnsTrue()
        {
            MyEnums.Schedule mySchedule = new MyEnums.Schedule();

            MyEnums.AddWeekDays("Tuesday Thursday", mySchedule.DaysOfWeek);

            Assert.IsTrue((mySchedule.DaysOfWeek & MyEnums.WeekDays.Tuesday) != 0);
            Assert.IsTrue((mySchedule.DaysOfWeek & MyEnums.WeekDays.Thursday) != 0);
        }

        [TestMethod]
        public void AddSeason_AddFall_ReturnsTrue()
        {
            MyEnums.Schedule mySchedule = new MyEnums.Schedule();

            MyEnums.AddSeason("fall", mySchedule.Quarter);

            Assert.IsTrue(mySchedule.Quarter == MyEnums.Seasons.Fall);
        }

        [TestMethod]
        public void ScheduleStruct_CreateMyScheduleFullOfProperties_MyScheduleLessThan16Bytes()
        {
            //MyEnums.Schedule mySchedule = new MyEnums.Schedule(12, 20, 0);

            int size = Marshal.SizeOf<MyEnums.Schedule>();

            Assert.AreEqual(size, 16);
            Assert.IsTrue(size <= 16);
        }
    }
}