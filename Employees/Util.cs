using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public static class Util
    {
        public static string AskForString(string prompt)
        {
            bool success = false;
            string name;

            do
            {
                Console.WriteLine($"{prompt}: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine($"You must enter a {prompt}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return name;
        }
    }
}
