using System;

namespace Assignment7
{
    public class MyDisposableClass
    {
        private bool Disposed { get; set; }

        public static int InstantiationCount { get; set; }

        public MyDisposableClass()
        {
            InstantiationCount++;
        }

        public void Dispose()
        {
            if (!Disposed)
            {
                InstantiationCount--;
                GC.SuppressFinalize(this);
            }

            Disposed = true;
        }

        ~MyDisposableClass()
        {
            Dispose();
        }

        public static void MakeAMyDisposableClassObjectForGarbageCollector()
        {
            MyDisposableClass someClass = new MyDisposableClass();
        }
    }
}