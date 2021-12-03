namespace Employees
{
    public class Employee
    {
        //Properties
        //Här utan setters vi kan alltså inte ändra värdet efter det satts
        public string Name { get; }
        public uint Salary { get; }


        public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.Junior : SalaryLevel.Senior;   
        //{
        //    get
        //    {
        //        if (Salary < 25000)
        //            return SalaryLevel.Junior;
        //        else
        //            return SalaryLevel.Senior;
        //    } 
        //}

        // public static int Count;


        //Konstruktor
        public Employee(string name, uint salary)
        {
            Name = name;
            Salary = salary;
            // Count++;
        }

        //Metoder
        //Vi specialiserar betendet av ToString() metoden. Istället för default implementationen så vill vi att den här koden körs när vi anropar .ToString() på en Employee instans
        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary} SalaryLevel {SalaryLevel}";
        }
    }
}