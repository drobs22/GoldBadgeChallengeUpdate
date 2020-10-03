using KomodoBadge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadgesConsole
{
    class BadgesProgramUI
    {
        private KomodoBadgeRepo _badgesRepo = new KomodoBadgeRepo();

        public void Run()
        {
            //Seed();
            Seed2();
            Menu();
        }

        // Menu

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display Menu Options

                Console.WriteLine("Hello, What would you like to do? Please type a number.\n" +
                    "1. Add a Badge\n" +
                    "2. Edit a Badge\n" +
                    "3. Show All Badges");

                // Get Input

                string input = Console.ReadLine();

                // Evalute and Act

                switch (input)
                {
                    case "1":
                        // Add a Badge
                        AddABadge();
                        break;
                    case "2":
                        //Edit a Badge
                        EditBadge();
                        break;
                    case "3":
                        //Show All Badges
                        SeeAllBadges();
                        break;
                    case "4":
                        //Exit
                        Console.WriteLine("Thank You. Have a nice day!");
                        //keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("I don't recognize that command. Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }


        }

        private void AddABadge()
        {
            Console.Clear();
            Badges addBadge = new Badges();

            // BadgeID
            Console.WriteLine("Please enter a new badge ID:");
            string badgeIDstring = Console.ReadLine();
            addBadge.BadgeID = int.Parse(badgeIDstring);

            // Door Name
            Console.WriteLine("Please enter the accessible door numbers:");
            addBadge.DoorName = Console.ReadLine();

            // Name
            Console.WriteLine("Please enter the employees name:");
            addBadge.Name = Console.ReadLine();
        }

        private void EditBadge()
        {

            Console.Clear();
            Badges addBadge = new Badges();

            // Display all ID's
            SeeAllBadges();
            // Ask for ID to be updated
            Console.WriteLine("Enter the Badge ID to be updated:");

            // Get ID


            // New Badge ID

            Console.WriteLine("Please enter a new badge ID:");
            string oldID = Console.ReadLine();
            addBadge.BadgeID = int.Parse(oldID);

            // Door Name
            Console.WriteLine("Please enter the accessible door numbers:");
            addBadge.DoorName = Console.ReadLine();

            // Name
            Console.WriteLine("Please enter the employees name:");
            addBadge.Name = Console.ReadLine();

            _badgesRepo.UpdateBadge(oldID, addBadge);

        }

        // See All Badges
        private void SeeAllBadges()
        {
            Console.Clear();

            List<Badges> listOfBadges = _badgesRepo.ShowBadges();
            foreach (Badges badges in listOfBadges)
            {
                Console.WriteLine($"Badge ID: {badges.BadgeID}\n " +
                    $"Door Name: {badges.DoorName}");
            }

            //Dictionary<int, string> listOfBadges = new Dictionary<int, string>();

            //foreach ( KeyValuePair<int, string> badge in listOfBadges)

            //{
            //    Console.WriteLine($"Badge #: {badge.Key}\n" +
            //        $"Door Access:{ badge.Value}");
            //}



        }


        // Seed Methods

        private void Seed2()
        {
            Badges badge1 = new Badges(1234, "A1, A2, A5", "Jim");
            Badges badge2 = new Badges(5678, "A2, A3, A4", "Suzy");
            Badges badge3 = new Badges(2468, "A3", "Julie");

            _badgesRepo.AddNewBadge(badge1);
            _badgesRepo.AddNewBadge(badge2);
            _badgesRepo.AddNewBadge(badge3);

        }


        //private void Seed()
        //{
        //    Dictionary<int, string> badge1 = new Dictionary<int, string>()
        //    {
        //        {1234, "A1, A2, A5" },
        //    };
        //    Dictionary<int, string> badge2 = new Dictionary<int, string>()
        //    {
        //        {5678, "A2, A3, A4" },
        //    };
        //    Dictionary<int, string> badge3 = new Dictionary<int, string>()
        //    {
        //        {2468, "A3" },
        //    };

        //    _badgesRepo.AddNewBadge();
        //    _badgesRepo.AddNewBadge();
        //    _badgesRepo.AddNewBadge();

        //    Dictionary<int, string> listOfBadges = new Dictionary<int, string>()
        //    {
        //        { 1234, "A1, A2, A5" },
        //        { 5678, "A2, A3, A4" },
        //        { 2468, "A3" },


        //    };


        //}
    }


}
