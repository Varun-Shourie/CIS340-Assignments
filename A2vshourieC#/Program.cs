using System;
using static System.Console;

namespace A2vshourie
{
    class MilesCalculator
    {
        static void Main(string[] args)
        {

            // The strings are designed to take in user input
            // regarding their destination and flyer status.
            // The remaining variables are used to derive the
            // earned flyer miles for the user. 
            string destinationCode = "";
            string flyerStatus = "";
            int distanceFlied = 0;
            double earnedMiles = 0.0;

            // Welcomes the user to the program interface.
            WriteLine("\t\t\tMiles Calculator\n\n");
            WriteLine("This program will calculate how many miles" +
                " you earn on your Phoenix Air flight.\n");

            // Provides a list of destinations for the user to select from for their trip
            // from the city of Phoenix.
            WriteLine("DESTINATIONS: ");
            WriteLine("Los Angeles (LAX)");
            WriteLine("San Diego (SAN)");
            WriteLine("Las Vegas (LAS)\n");

            // An instance of the Scanner class is created to take user input regarding
            // which destination they are traveling to. 
            Write("Enter destination airport code: ");
            destinationCode = ReadLine();

            // Based on the destination code entered, the user will travel a certain distance.
            // If the user travels to Los Angeles, they will travel 369 miles from PHX.
            // If the user travels to San Diego, they will travel 304 miles from PHX.
            // If the user travels to Las Vegas, they will travel 255 miles from PHX.
            // If the user enters another destination, they will no receive no flyer
            // miles because Phoenix Air does not service that area and the 
            // program will be terminated. 
            switch (destinationCode)
            {
                case "LAX":
                    distanceFlied = 369;
                    break;
                case "SAN":
                    distanceFlied = 304;
                    break;
                case "LAS":
                    distanceFlied = 255;
                    break;
                default:
                    distanceFlied = 0;
                    WriteLine();
                    Write("Phoenix Air does not fly to {0}. There will" +
                        " be no miles earned.\n", destinationCode);
                    Write("Press enter to quit... ");   
                    ReadLine();
                    Environment.Exit(0);
                    break;
            }

            WriteLine();

            // Provides a list of frequent flyer status options for the user to select from.
            WriteLine("STATUS: ");
            WriteLine("1. Bronze");
            WriteLine("2. Silver");
            WriteLine("3. Gold");
            WriteLine("4. Platinum\n");

            // The user will tell the console application what kind of frequent flyer they are.
            Write("Enter frequent flyer status option (1-4): ");
            flyerStatus = ReadLine();

            // If the user's a bronze flyer, their flyer miles are equal to the distance traveled.
            // If a silver flyer, their flyer miles are equal to 125% of the distance traveled.
            // If a gold flyer, their flyer miles are equal to 150% of the distance traveled.
            // If a platinum flyer, their flyer miles are equal to 200% of the distance traveled.
            // If they are not a flyer, their flyer miles are equal to the distance traveled.
            switch (flyerStatus)
            {
                case "1":
                    earnedMiles = distanceFlied;
                    break;
                case "2":
                    earnedMiles = distanceFlied * 1.25;
                    break;
                case "3":
                    earnedMiles = distanceFlied * 1.50;
                    break;
                case "4":
                    earnedMiles = distanceFlied * 2.00;
                    break;
                default:
                    earnedMiles = distanceFlied;
                    break;
            }

            Write("\n");

            // Prints out the number of frequent flyer miles earned for the user
            // from flying to their inputted location.
            Write("You will earn {0:0.00} miles flying from Phoenix to {1}", earnedMiles, destinationCode);
            Write("\n");
        }
    }
}
