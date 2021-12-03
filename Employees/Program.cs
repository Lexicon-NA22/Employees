using System;

namespace Employees
{
    internal class Program
    {
        //Instansierar en payroll och ett ui
        //Scoopade till hela klassen
        static PayRoll payRoll = new PayRoll();
        static IUI ui = new ConsoleUI();

        //Programmets startpunkt
        //Får bara finnas EN!
        static void Main(string[] args)
        {
            //Skapar lite dummy data
            SeedData();

            //ProgramLoop körs till användaren väljer att avsluta
            do
            {
                ShowMainMeny();
                UserInput();

            } while (true);


        }

        //Tar ett värde från användaren
        //Testar olika case. Användaren skriver in "1" då körs AddEmployee metoden. 
        //Om vi inte träffar något case körs default koden
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
                    //Avslutar programmet
                    Environment.Exit(0);
                    break;
                default:
                    ui.PrintString("Wrong input");
                    break;
            }
        }

        private static void AddEmployee()
        {
            //Loopar tills användaren trycker "Q"
            do
            {
                ui.PrintString("Add an employee, Q for quit");
                string name = Util.AskForString("Name", ui);    //Säkerställer att vi får en input som inte är tom

                if (name.Equals("Q")) break;                    //Avslutar loopen och återgår till ProgramLoopen

                uint salary = Util.AskForUInt("Salary", ui);    //Säkerställer att vi får tillbaks en uint

                payRoll.AddEmployee(name, salary);

            } while (true);

        }

        private static void PrintEmplyees()
        {
            //Hämtar alla Employees från PayRoll.
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