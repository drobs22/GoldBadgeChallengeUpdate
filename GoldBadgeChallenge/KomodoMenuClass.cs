using GoldBadgeChallenge;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallenge
{

    public class Menu

    {

        public int MealNum { get; set; }
        public string Name { get; set; }
        public string SandwichName { get; set; }
        public bool Chips { get; set; }
        public bool Drink { get; set; }
        public decimal Price { get; set; }



        public Menu(int mealNum, string name, string sandwichName, bool chips, bool drink, decimal price)
        {
            Name = name;
            MealNum = mealNum;
            SandwichName = sandwichName;
            Chips = chips;
            Drink = drink;
            Price = price;

        }

        public Menu()
        {

        }

    }

    public class TheBigTurkeyIngredients
    {
        public string Bread { get; set; }
        public string Turkey { get; set; }
        public bool Lettuce { get; set; }

        public bool Tomato { get; set; }
        public bool Mayo { get; set; }

        public TheBigTurkeyIngredients(string bread, string turkey, bool lettuce, bool tomato, bool mayo)
        {
            Bread = bread;
            Turkey = turkey;
            Lettuce = lettuce;
            Tomato = tomato;
            Mayo = mayo;

        }

        public TheBigTurkeyIngredients()
        { }

    }

    public class DontBeAChickenIngredients
    {
        public string Bread { get; set; }
        public string Chicken { get; set; }
        public bool Lettuce { get; set; }

        public bool Tomato { get; set; }
        public bool HotSauce { get; set; }

        public DontBeAChickenIngredients(string bread, string chicken, bool lettuce, bool tomato, bool hotSauce)
        {
            Bread = bread;
            Chicken = chicken;
            Lettuce = lettuce;
            Tomato = tomato;
            HotSauce = hotSauce;

        }

        public DontBeAChickenIngredients()
        { }



    }

    public class WedgieIngredients
    {
        public string Lettuce { get; set; }
        public bool Bacon { get; set; }
        public bool Tomato { get; set; }
        public bool BlueCheese { get; set; }

        public WedgieIngredients(string lettuce, bool bacon, bool tomato, bool blueCheese)
        {
            Lettuce = lettuce;
            Bacon = bacon;
            Tomato = tomato;
            BlueCheese = blueCheese;

        }

        public WedgieIngredients()
        { }

    }





}
