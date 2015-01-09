using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payroll.Test
{
    [TestClass]
    public class EmployeesTest
    {

        [TestMethod]
        public void ShouldReturnActiveUserById()
        {
            var employee = new Employees().GetBy(3, true);

            Assert.AreEqual(3, employee.Id);
            Assert.AreEqual(null, employee.TerminationDate);
            Assert.AreEqual(999, employee.SubsidiaryId);
        }

        [TestMethod]
        public void ShouldReturnInactiveUserById()
        {
            var employee = new Employees().GetBy(1, false);

            Assert.AreEqual(1, employee.Id);
            Assert.AreEqual(new DateTime(2010, 10, 1), employee.TerminationDate);
            Assert.AreEqual(999, employee.SubsidiaryId);
        }

        [TestMethod]        
        public void ShouldNotReturAnynActiveElement()
        {
            var employee = new Employees().GetBy(1, true);
            Assert.IsNull(employee);
        }

        [TestMethod]
        public void ShouldNotReturAnynInactiveElement()
        {
            var employee = new Employees().GetBy(2, true);
            Assert.IsNull(employee);
        }
    }
}
