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
        public string GetStringInput()
        {
            return "1";
        }

        public void PrintString(string message)
        {

        }
    }
}
