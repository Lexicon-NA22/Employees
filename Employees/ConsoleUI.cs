using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class ConsoleUI : IUI
    {
        public string GetStringInput()
        {
            return Console.ReadLine();
        }

        public void PrintString(string message)
        {
            Console.WriteLine(message);
        }

        public void SpecifikConsoleUiMethod()
        {
            //
        }
    }

    public class MockUI : IUI
    {
        private static string defaultGetInput = "1";
        public static string SetGetInput { private get; set; } = defaultGetInput;
        public string GetStringInput()
        {
            return SetGetInput;
        }

        public void PrintString(string message)
        {

        }
    }
}
