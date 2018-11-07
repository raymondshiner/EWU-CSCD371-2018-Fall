using System;

namespace Assignment6
{
    public class MyClass
    {
        public int ClassInt { get; set; }

        public static void ChangeClassIntToZero(MyClass myClass)
        {
            myClass.ClassInt = 0;
        }

        public static void ChangeStructIntToZero(MyStruct myStruct)
        {
            myStruct.StructInt = 0;
        }

        public static void ChangeStructIntToZeroByRef(ref MyStruct myStruct)
        {
            myStruct.StructInt = 0;
        }

        public static void ChangeIStructInterfaceStructIntToZero(ref IStructInterface myStructInterface)
        {
            myStructInterface.StructInt = 0;
        }


        public static void MakeNewInstanceOfClass(ref MyClass myClass)
        {
            MyClass newC = new MyClass();
            myClass = newC;
        }
    }

    public struct MyStruct : IStructInterface
    {
        public int StructInt { get; set; }
    }

    public interface IStructInterface
    {
        int StructInt { get; set; }
    }
}
