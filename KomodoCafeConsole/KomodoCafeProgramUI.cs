using GoldBadgeChallenge;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace KomodoCafeConsole
{

    class KomodoCafeProgramUI
    {
        private KomodoCafeRepo _menuRepo = new KomodoCafeRepo();
        //private KomodoCafeRepo _theBigTurkeyRepo = new KomodoCafeRepo();
        //private KomodoCafeRepo _dontBeAChickenRepo = new KomodoCafeRepo();
        //private KomodoCafeRepo _wedgieRepo = new KomodoCafeRepo();


        // Method starting the application
        public void Run()
        {
            SeedMenuList();
          
            Menu();
        }

        // Menu Method
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display Options to Use
                System.Console.WriteLine("Please select a menu option by number:\n" +
                    "1. See the Menu Items\n" +
                    "2. Add a Menu Item\n" +
                    "3. Delete a Menu Item\n" +
                    "4. The Big Turkey Ingredients\n" +
                    "5. Don't Be a Chicken Ingredients\n" +
                    "6. The Wedgie Ingredients\n" +
                    "7. Exit Application");

                //Get user input
                string input = Console.ReadLine();

                //Evaluate input and act
                switch (input)
                {
                    case "1":
                        // See All Menu Items
                        DisplayFoodMenu();

                        break;
                    case "2":
                        // Add a Menu Item
                        AddMenuItem();
                        break;
                    case "3":
                        // Delete a Menu Item
                        RemoveMenuItem();
                        break;
                    case "4":
                        // The Big Turkey Ingredients
                        TheBigTurkeyIngredients();
                        break;
                    case "5":
                        // Don't Be a Chicken Ingredients
                        DontBeAChickenIngredients();
                        break;
                    case "6":
                        // The Wedgie Ingredients
                        WedgieIngredients();
                        break;
                    case "7":
                        // exit app
                        Console.WriteLine("See you later. have a good day!");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number!");
                        break;

                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadLine();
                Console.Clear();


            }

        }
        // Display Menu Items
        private void DisplayFoodMenu()
        {
            Console.Clear();
            List<Menu> menuList = _menuRepo.ShowMenu();

            foreach (Menu menu in menuList)
            {
                Console.WriteLine($"Meal Number: {menu.MealNum}, {menu.Name}\n" +
                    $"Sandwich: {menu.SandwichName}\n" +
                    $"Chips: {menu.Chips}\n" +
                    $"Drink: {menu.Drink}\n" +
                    $"Price: {menu.Price}");
            }
        }

        // Add a Menu Item
        private void AddMenuItem()
        {

            Console.Clear();
            Menu addItem = new Menu();

            // Name
            Console.WriteLine("Enter the Name of the new meal");
            addItem.Name = Console.ReadLine();

            // Meal Number
            Console.WriteLine("Enter the meal number of the new meal");
            string mealNumberString = Console.ReadLine();
            addItem.MealNum = int.Parse(mealNumberString);

            // Sandwich
            Console.WriteLine("Enter the type of sandwich for the new meal");
            addItem.SandwichName = Console.ReadLine();

            // Chips
            Console.WriteLine("Does this meal come with chips? (y/n)");
            string chipString = Console.ReadLine().ToLower();

            if (chipString == "y")
            {
                addItem.Chips = true;
            }
            else
            {
                addItem.Chips = false;
            }

            // Drink
            Console.WriteLine("Does this meal come with a drink? (y/n)");
            string drinkString = Console.ReadLine().ToLower();

            if (drinkString == "y")
            {
                addItem.Drink = true;
            }
            else
            {
                addItem.Drink = false;
            }


            // Cost
            Console.WriteLine("How much does the new meal cost");
            string priceAsString = Console.ReadLine();
            addItem.Price = decimal.Parse(priceAsString);

            _menuRepo.AddNewItem(addItem);

        }

        // Delete a Menu Item

        private void RemoveMenuItem()
        {


            DisplayFoodMenu();
            //Get Menu Item to delete
            Console.WriteLine("\n Which menu item would you like to remove?");
            string input = Console.ReadLine();


            //Call delete method

            bool wasDeleted = _menuRepo.RemoveItemFromMenu(input);


            //Say if content was deleted

            //Otherwise state it could not be deleted

            if (wasDeleted)
            {
                Console.WriteLine("The item was deleted!");
            }
            else
            {
                Console.WriteLine("The item was not deleted!");
            }


        }

        private void TheBigTurkeyIngredients()
        {
            Console.Clear();

            Console.WriteLine($"Bread\n" +
                "Turkey\n" +
                "Lettuce\n" +
                "Tomato\n" +
                "Mayo\n");


        }

        private void DontBeAChickenIngredients()
        {
            Console.Clear();

            Console.WriteLine($"Bread\n" +
                $"Grilled Chicken\n" +
                $"Lettuce\n" +
                $"Tomato\n" +
                $"Buffalo Hot Sauce\n");


        }

        private void WedgieIngredients()
        {
            Console.Clear();

            Console.WriteLine($"Iceburg Lettuce Wedge\n" +
                $"Bacon\n"+
                $"Diced Tomatos\n"+
                $"Blue Cheese Dressing");
           

        }
        private void SeedMenuList()
        {
            Menu turkey = new Menu(1, "The Big Turkey", "Turkey", true, true, 11.50m);
            Menu chicken = new Menu(2, "Don't Be Chicken", "Chicken", true, true, 12.50m);
            Menu wedge = new Menu(3, "Wedgie", "wedge salad", false, true, 10.00m);
            Menu chocolateCake = new Menu(4, "Chocolate Thunder", "chocolate Cake", false, false, 5.00m);
            

            _menuRepo.AddNewItem(turkey);
            _menuRepo.AddNewItem(chicken);
            _menuRepo.AddNewItem(wedge);
            _menuRepo.AddNewItem(chocolateCake);
                  

        }

       
    }

}
