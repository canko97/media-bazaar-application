using System;
using MediaBazaarApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaBazaarUnitTestProject
{
    [TestClass]
    public class EmployeeLogicUnitTest
    {
        [TestMethod]
        public void GeneratePasswordTest()
        {
            // Arrange
            EmployeesLogic employeesLogic = new EmployeesLogic();

            // Act
            employeesLogic.GeneratePassword();

            // Assert
        }
    }
}
