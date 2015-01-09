using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payroll.Test
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void ShouldBeActiveWhenTerminationDataIsNullAndSubsidiaryIdIs999()
        {
            var employee = new Employee()
            {
                TerminationDate = null,
                SubsidiaryId = 999
            };
            Assert.IsTrue(employee.IsActive);
        }

        [TestMethod]
        public void ShouldBeNotActiveWhenTerminationDataIsNotNullAndSubsidiaryIdIs999()
        {
            var employee = new Employee()
            {
                TerminationDate = new DateTime(2014, 02, 02),
                SubsidiaryId = 999
            };
            Assert.IsFalse(employee.IsActive);
        }
    }
}
