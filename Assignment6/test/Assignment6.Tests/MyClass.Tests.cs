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
        public void PassClassToMethod_ChangePropertyValue_OriginalClassChanged()
        {
            MyClass myClass = new MyClass();
            myClass.ClassInt = 10;

            MyClass.ChangeClassIntToZero(myClass);

            Assert.AreEqual(myClass.ClassInt, 0);
        }

        [TestMethod]
        public void PassClassToMethod_CreateNewReference_OriginalClassChanged()
        {
            MyClass myClass = new MyClass();
            MyClass checkClass = myClass;

            myClass.ClassInt = 10;

            MyClass.MakeNewInstanceOfClass(ref myClass);

            Assert.IsFalse(myClass == checkClass);
        }

        [TestMethod]
        public void ChangeIStructInterfaceStructIntToZero_CastStructToInterfaceAndPassIn_ReturnsTrue()
        {
            MyStruct myStruct = new MyStruct();
            myStruct.StructInt = 10;

            IStructInterface myInterface = (IStructInterface) myStruct;

            MyClass.ChangeIStructInterfaceStructIntToZero(ref myInterface);

            Assert.AreEqual(myInterface.StructInt, 0);
        }
    }
}
