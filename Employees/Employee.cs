namespace Employees
{
    public class Employee
    {
        public string Name { get; }
        public uint Salary { get; }

       // public static int Count;

        public Employee(string name, uint salary)
        {
            Name = name;
            Salary = salary;
           // Count++;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}