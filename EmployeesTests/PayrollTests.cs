using Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesTests
{
    [TestClass]
    public class PayrollTests
    {

        [TestMethod]
        public void GetEmployees_ShouldReturnInstance()
        {
            var payroll = new PayRoll();

            var actual = payroll.GetEmployees();

            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void AddEmployee_Should_Add()
        {
            var payroll = new PayRoll();
            const string exspectedName = "Kalle";
            const uint expectedeSalary = 10000;

            payroll.AddEmployee(new Employee(exspectedName, expectedeSalary));
            var actual = payroll.GetEmployees()[0];

            Assert.AreEqual(exspectedName, actual.Name);
            Assert.AreEqual(expectedeSalary, actual.Salary);
        }
    }
}
