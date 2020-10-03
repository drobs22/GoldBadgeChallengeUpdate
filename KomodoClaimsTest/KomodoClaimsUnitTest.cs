using System;
using KomodoClaims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoClaimsTest
{
    [TestClass]
    public class KomodoClaimsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Claims claim2 = new Claims(2, "Home", "House fire in Kitchen", 400, 4 / 11 / 2018, 4 / 12 / 2018, true)

            // Arange

            int claimID = 2;
            string claimType = "Home";
            string description = "House fire in Kitchen";
            decimal amount = 400m;
            int dateOfIncident = 4/11/2018;
            int dateOfClaim = 4/12/2018;
            bool valid = false;

            // Act

            Claims testclaim = new Claims(claimID, claimType, description, amount, dateOfIncident, dateOfClaim, valid);

            // Assert

            Assert.AreEqual(claimID, testclaim.ClaimID);
            Assert.IsTrue(valid);
     
        }
    }
}
