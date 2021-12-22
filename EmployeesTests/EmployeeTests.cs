using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestInitialize]
        public void TestInit()
        {

        }

        [TestMethod]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior()
        {
            //Arrange
            const int juniorSalary = 10000;
            const string name = "Kalle";
            var employee = new Employee(name, juniorSalary);

           //Act
           var actual = employee.SalaryLevel;

           //Assert
           Assert.AreEqual(SalaryLevel.Junior, actual);
        }

    }
}