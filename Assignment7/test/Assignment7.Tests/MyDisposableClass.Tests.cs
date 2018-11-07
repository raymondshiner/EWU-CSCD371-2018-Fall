using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment7.Tests
{
    [TestClass]
    public class MyDisposableClassTests
    {
        [TestMethod]
        public void MyDispoableClass_ForgetToDisposeDisposableClass_InstantiationCountShouldStillBeChanged()
        {
            MyDisposableClass.InstantiationCount = 0;

            MyDisposableClass.MakeAMyDisposableClassObjectForGarbageCollector();

            Assert.AreEqual(0, MyDisposableClass.InstantiationCount);
        }
    }
}
