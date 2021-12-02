using System;

namespace Employees
{
    internal class Program
    {
        static PayRoll payRoll = new PayRoll();

        static void Main(string[] args)
        {
            SeedData();

            do
            {
                ShowMainMeny();

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmplyees();
                        break;

                    case "Q":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

            } while (true);


        }

        private static void AddEmployee()
        {
            do
            {
                Console.WriteLine("Add an employee, Q for quit");
                string name = Util.AskForString("Name");

                if (name.Equals("Q")) break;

                uint salary = Util.AskForUInt("Salary");

                payRoll.AddEmployee(name, salary);

            } while (true);

        }

        private static void PrintEmplyees()
        {
            var employees = payRoll.GetEmployees();

            foreach (var emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("1: add employee");
            Console.WriteLine("2: print employee");
            Console.WriteLine("Q: quit");
        }

        private static void SeedData()
        {
            payRoll.AddEmployee("Kalle", 25000);
            payRoll.AddEmployee("Nisse", 20000);
            payRoll.AddEmployee("Anna", 30000);
            payRoll.AddEmployee("Lena", 35000);
            payRoll.AddEmployee(new Employee("Lena", 35000));
        }
    }
}

//Clean upp ctrl k d