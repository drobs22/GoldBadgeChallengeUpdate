using GoldBadgeChallenge;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.Eventing.Reader;

namespace GoldBadgeChallenge
{
    [TestClass]
    public class KomodoMenuTest
    {
        [TestMethod]
        public void MenuTest()
        {


            // Arrange -Set up the pieces
           
            int mealNumber = 1;
            string mealName = "The Big Turkey";
            string sandwichType = "Turkey";
            bool chips = true;
            bool drink = true;
            decimal cost = 11.00m;

            // Act

            Menu testMenu = new Menu(mealNumber, mealName, sandwichType, chips, drink, cost);

            //Assert

            Assert.AreEqual(mealNumber, testMenu.MealNum, mealName, testMenu.Name);
            Assert.IsTrue(drink);
            


        }

       

      
    }
}
