using System;

namespace Assignment5
{
    public interface IConsole
    {
        void WriteLine(string str);
    }

    public class MyConsole : IConsole
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }

        public void Write(string str)
        {
            Console.Write(str);
        }
    }
}
