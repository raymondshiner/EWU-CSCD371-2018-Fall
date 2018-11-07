using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment6.Tests
{
    [TestClass]
    public class MyClassTests
    {
        [TestMethod]
        public void PassStructToMethod_ChangePropertyValue_OriginalStructUnchanged()
        {
            MyStruct myStruct = new MyStruct();
            myStruct.StructInt = 10;

            MyClass.ChangeStructIntToZero(myStruct);

            Assert.AreEqual(myStruct.StructInt, 10);
        }

        [TestMethod]
        public void PassStructToMethod_ChangePropertyValue_OriginalStructChanged()
        {
            MyStruct myStruct = new MyStruct();
            myStruct.StructInt = 10;

            MyClass.ChangeStructIntToZeroByRef(ref myStruct);

            Assert.AreEqual(myStruct.StructInt, 0);
        }

        [TestMethod]
        public void PassClassToMethod_ChangePropertyValue_OriginalClassUnchanged()
        {

        }
    }
}
