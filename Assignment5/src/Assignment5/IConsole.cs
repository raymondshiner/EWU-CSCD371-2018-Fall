using System;

namespace Assignment5
{
    public interface IConsole
    {
        void WriteLine(string str);
        void Write(string str);
        string ReadLine();
        string LastWrittenLine { get; } 
    }

    public class MyConsole : IConsole
    {
        public string LastWrittenLine { get; private set; }

        public void WriteLine(string str)
        {
            Console.WriteLine(str);
            LastWrittenLine = str;
        }

        public void Write(string str)
        {
            Console.Write(str);
            LastWrittenLine = str;
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
