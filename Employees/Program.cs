using System;

namespace Employees
{
    internal class Program
    {
        static PayRoll payRoll = new PayRoll();
        
        static void Main(string[] args)
        {
            SeedData();
            //Employee employee = new Employee(name: "Kalle", salary: 20000);

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

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

            } while (true);

           
        }

        private static void AddEmployee()
        {
            Console.WriteLine("Add an employee");
            bool success = false;
            string name;

            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("You must enter a name");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            bool success2 = false;
            string salary;

            do
            {
                Console.WriteLine("Salary: ");
                salary = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("You must enter a salary");
                }
                else
                {
                    success2 = true;
                }


            } while (!success2);

           payRoll.AddEmployee(name, int.Parse(salary));

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
            Console.WriteLine("3: quit");
        }

        private static void SeedData()
        {
            payRoll.AddEmployee("Kalle", 25000);
            payRoll.AddEmployee("Nisse", 20000);
            payRoll.AddEmployee("Anna", 30000);
            payRoll.AddEmployee("Lena", 35000);
        }
    }
}
