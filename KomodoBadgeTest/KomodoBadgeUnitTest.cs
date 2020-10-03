using System;
using System.Linq;
using KomodoBadge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoBadgeTest
{
    [TestClass]
    public class KomodoBadgeUnitTest
    {
        [TestMethod]
        public void Badge_Test()
        {

            // Arrange 

            int badgeID = 1234;
            string door = "A3, A4";
            string name = "Drew";




            // Act

            Badges testBadge = new Badges(badgeID, door, name);



            // Assert

            Assert.AreEqual(badgeID, testBadge.BadgeID);
            Assert.AreEqual(door, testBadge.DoorName);
            Assert.AreEqual(name, testBadge.Name);
           


        }
    }
}
