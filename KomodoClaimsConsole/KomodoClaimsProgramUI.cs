

using KomodoClaims;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsConsole
{
    class KomodoClaimsProgramUI
    {

        private KomodoClaimsRepo _claimsRepo = new KomodoClaimsRepo();

        Claims claim1 = new Claims(1, "Car", "Car Accident on 465", 400, new DateTime(2018, 04, 26), new DateTime (2018, 04,27), true);
        Claims claim2 = new Claims(2, "Home", "House fire in Kitchen", 400, new DateTime(2018, 04, 11), new DateTime (2018, 04, 12), true);
        Claims claim3 = new Claims(3, "Theft", "Stolen Pancakes", 4, new DateTime(2018, 04, 27), new DateTime (2018, 06, 01), false);



        // Method to Start App

        public void Run()
        {
            SeedClaims();
            //Queue();
            Menu();
        }

        // Menu

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display Options to User
                Console.WriteLine("Select a Menu Option:\n" +
                    "1. See All Claims:\n" +
                    "2. Take Care of Next Claim:\n" +
                    "3. Enter New Claim:\n" +
                    "4. Exit"
                    );

                // Get Users Input
                string input = Console.ReadLine();

                // Evaluate and Act

                switch (input)
                {
                    case "1":
                        // See all claims
                        SeeAllClaims();
                        break;
                    case "2":
                        // Take care of next claim
                        NextClaim();
                        break;
                    case "3":
                        //Enter new claim
                        NewClaim();
                        break;
                    case "4":
                        // Exit
                        Console.WriteLine("Have a nice day!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;

                }


                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }

        }

        // See All Claims
        private void SeeAllClaims()
        {
            Console.Clear();


            List<Claims> listOFClaims = _claimsRepo.ShowClaims();
            foreach (Claims content in listOFClaims)
            {
                Console.WriteLine($"Claim ID: {content.ClaimID}\n" +
                    $"Claim Type: {content.ClaimType}\n" +
                    $"Descrption: {content.Description}\n" +
                    $"Claim Amount: {content.ClaimAmount}\n" +
                    $"Date Of Incident: {content.DateOfIncident}\n" +
                    $"Date Of Claim: {content.DateOfClaim}\n" +
                    $"Is the Claim Valid: {content.IsValid}");

            }

            

        }

        // Take Care of Next Claim
        private void NextClaim()
        {
            Console.Clear();
            Console.WriteLine("Here is the next claim");

            //Claims[] claimsById = new Claims[]
            //     {
            //    new Claims { ClaimID = 1, ClaimType = "Car", Description = "Car Accident on 465", ClaimAmount = 400.00m, DateOfIncident = 04 / 25 / 2018, DateOfClaim = 04 / 25 / 2018, IsValid = true },
            //    new Claims { ClaimID = 2, ClaimType = "Home", Description = "House fire in Kitchen", ClaimAmount = 400.00m, DateOfIncident = 04 / 11 / 2018, DateOfClaim = 04 / 12 / 2018, IsValid = true },
            //    new Claims { ClaimID = 3, ClaimType = "Theft", Description = "Stolen Pancakes", ClaimAmount = 4.00m, DateOfIncident = 04 / 27 / 2018, DateOfClaim = 06 / 01 / 2018, IsValid = false },
            //};


            Queue claimsById = new Queue();

            claimsById.Enqueue(claim1);
            claimsById.Enqueue(claim2);
            claimsById.Enqueue(claim3);


            Console.WriteLine(claimsById.Peek());

            // I cannot get this to work. The console returns "KomodoClaims.Claims". I did not get aroud to doing the rest of the method.
        }
        

        // Create a New Claim
        private void NewClaim()
        {
            Console.Clear();

            Claims newClaim = new Claims();

            // Claim ID
            Console.WriteLine("Enter the claim ID:");
            string idAsSting = Console.ReadLine();
            newClaim.ClaimID = int.Parse(idAsSting);

            // Claim Type

            Console.WriteLine("Enter the claim type:");
            newClaim.ClaimType = Console.ReadLine();


            // Description

            Console.WriteLine("Enter the description of the incident:");
            newClaim.Description = Console.ReadLine();

            // Claim Amount 

            Console.WriteLine("Enter the claim amount:");
            string amountAsString = Console.ReadLine();
            newClaim.ClaimAmount = decimal.Parse(amountAsString);

            // Date of Incident

            Console.WriteLine("Enter the date of the incident (month(00)/day(00)/year(0000);");
            string dateOfIncidentAsString = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(dateOfIncidentAsString);




            // Date of Claim

            Console.WriteLine("Enter the date of the claim (month(00)/day(00)/year(0000);");
            string dateOfClaimtAsString = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(dateOfClaimtAsString);



            // Is it a valid claim

            Console.WriteLine("Was the claim made within 30 days of the incident?");
            string validClaimAsString = Console.ReadLine();
            if (validClaimAsString == "y")
            {
                newClaim.IsValid = true;
            }
            else
            {
                newClaim.IsValid = false;
            }

            _claimsRepo.AddNewClaim(newClaim);

        }

        private void SeedClaims()
        {


            Claims claim1 = new Claims(1, "Car", "Car Accident on 465", 400, new DateTime (2018, 04, 26), new DateTime (2018, 04, 27), true);
            Claims claim2 = new Claims(2, "Home", "House fire in Kitchen", 400, new DateTime (2018, 04, 11), new DateTime (2018, 04, 12), true);
            Claims claim3 = new Claims(3, "Theft", "Stolen Pancakes", 4, new DateTime (2018, 04, 27), new DateTime(2018, 06, 1), false);

            _claimsRepo.AddNewClaim(claim1);
            _claimsRepo.AddNewClaim(claim2);
            _claimsRepo.AddNewClaim(claim3);
        }

        //private void Queue()
        //{
        //    Claims[] claimsById = new Claims[]
        //    {
        //        new Claims { ClaimID = 1, ClaimType = "Car", Description = "Car Accident on 465", ClaimAmount = 400.00m, DateOfIncident = 04/25/2018, DateOfClaim = 04/25/2018, IsValid = true},
        //        new Claims { ClaimID = 2, ClaimType = "Home", Description = "House fire in Kitchen", ClaimAmount = 400.00m, DateOfIncident = 04/11/2018, DateOfClaim = 04/12/2018, IsValid = true },
        //        new Claims { ClaimID = 3, ClaimType = "Theft", Description= "Stolen Pancakes", ClaimAmount = 4.00m, DateOfIncident = 04/27/2018, DateOfClaim = 06/01/2018, IsValid = false}
        //    };


        //}
    }

}
