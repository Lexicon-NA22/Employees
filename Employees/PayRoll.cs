using System.Collections.Generic;
using System.Linq;

namespace Employees
{
    public class PayRoll
    {
        //private fält
        private List<Employee> payroll;

        //Konstruktor
        public PayRoll()
        {
            payroll = new List<Employee>();
        }

        //Metoder
        public void AddEmployee(string name, uint salary)
        {
            //Validate
            Employee employee = new Employee(name, salary);
            payroll.Add(employee);
        }    
        
        public void AddEmployee(Employee emp)
        {
            //Validate
           // Employee employee = new Employee(name, salary);
            payroll.Add(emp);
        }

        public List<Employee> GetEmployees()
        {
            return payroll.ToList();
        }
    }
}