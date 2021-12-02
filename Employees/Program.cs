using System;

namespace Employees
{
    internal class Program
    {
        static PayRoll payRoll = new PayRoll();
        static IUI ui = new ConsoleUI();

        static void Main(string[] args)
        {
            SeedData();

            do
            {
                ShowMainMeny();
                UserInput();

            } while (true);


        }

        private static void UserInput()
        {
            var input = ui.GetStringInput();
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
        }

        private static void AddEmployee()
        {
            do
            {
                ui.PrintString("Add an employee, Q for quit");
                string name = Util.AskForString("Name", ui);

                if (name.Equals("Q")) break;

                uint salary = Util.AskForUInt("Salary", ui);

                payRoll.AddEmployee(name, salary);

            } while (true);

        }

        private static void PrintEmplyees()
        {
            var employees = payRoll.GetEmployees();

            foreach (var emp in employees)
            {
                ui.PrintString(emp.ToString());
            }
        }

        private static void ShowMainMeny()
        {
            ui.PrintString("1: add employee");
            ui.PrintString("2: print employee");
            ui.PrintString("Q: quit");
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