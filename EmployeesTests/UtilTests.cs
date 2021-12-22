using Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesTests
{
    [TestClass]
    public class UtilTests
    {
        private Mock<IUI> ui;

        [TestInitialize]
        public void Init()
        {
             ui = new Mock<IUI>();
        }

        [TestMethod]
        public void AskForString_ReturnsString()
        {
              const string expected = "Kalle";
              var mockUI = new MockUI();
              MockUI.SetGetInput = expected;

              var actual = Util.AskForString("Name: ", mockUI);

              Assert.AreEqual(expected, actual);

        } 
        
        [TestMethod]
        public void AskForString_ReturnsString2()
        {
              const string expected = "Kalle";
              ui.Setup(u => u.GetStringInput()).Returns(expected);

              var actual = Util.AskForString("Name: ", ui.Object);

              Assert.AreEqual(expected, actual);

        } 
        
    }
}
