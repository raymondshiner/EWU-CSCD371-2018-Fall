using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment5.Tests
{
    public class MockConsole : IConsole
    {
        public List<string> Input { get; set; }
        public List<string> Output { get; set; }
        public int ConsoleReadLineCount { get; set; }
        public string LastWrittenLine { get; private set; }

        public MockConsole()
        {
            Input = new List<string>();
            Output = new List<string>();
            ConsoleReadLineCount = 0;
            LastWrittenLine = "";
        }

        public void WriteLine(string str)
        {
            LastWrittenLine = str;
            Output.Add(str);
        }

        public void Write(string str)
        {
            LastWrittenLine = str;
            Output.Add(str);
        }

        public string ReadLine()
        {
            string str = Input[ConsoleReadLineCount];
            ConsoleReadLineCount++;
            return str;
        }
    }
}
