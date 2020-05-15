// A2, Varun Shourie, CIS340, Tuesday/Thursday, 3:00PM-4:15PM

import java.util.Scanner;

public class MilesCalculator {

	public static void main(String[] args) {
		
		// The two strings are used to take in valuable user input regarding
		// what their destination and flyer status is. 
		// Based on their destination, their distance is ascertained.
		// Based on the distance and their flyer status, the user's 
		// earned miles is derived at the end of the program. 
		String destinationCode = "";
		String flyerStatus = "";
		int distanceFlied = 0;
		double earnedMiles = 0.0;
		
		// Welcomes the user to the program interface. 
		System.out.println("\t\t\tMiles Calculator\n\n");
		System.out.println("This program will calculate how many miles"
				+ " you earn on your Phoenix Air flight.\n");
		
		// Provides a list of destinations for the user to select from for 
		// their trip from Phoenix. 
		System.out.println("DESTINATIONS: ");
		System.out.println("Los Angeles (LAX)");
		System.out.println("San Diego (SAN)");
		System.out.println("Las Vegas (LAS)\n");
		
		// An instance of the Scanner class is created to take user input regarding 
		// which destination they are traveling to. 
		Scanner scanner = new Scanner(System.in);
		System.out.print("Enter destination airport code: ");
		destinationCode = scanner.nextLine();
		
		// Based on the destination code entered by the user, the user will
		// travel a certain distance. 
		// If the user travels to Los Angeles, they will travel 369 miles from PHX.
		// If the user travels to San Diego, they will travel 304 miles from PHX.
		// If the user travels to Las Vegas, they will travel 255 miles from PHX.
		// If the user enters another destination, we assume they receive
		// no flyer miles since Phoenix Air does not service that area. 
		// The program will also be terminated if the user enters another
		// destination since further calculations are not necessary.
		switch (destinationCode) {
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
			System.out.println();
			System.out.printf("Phoenix Air does not fly to %s. "
					+ "There will be zero miles earned.\n", destinationCode);
			System.out.print("Press enter to quit...");
			scanner.nextLine();
			System.exit(0);
			break;
		}
		
		System.out.println();
		
		// Provides a list of frequent flyer status options for the user to select
		// from. The option that they select represents the kind of frequent
		// flyer they are. 
		System.out.println("STATUS: ");
		System.out.println("1. Bronze");
		System.out.println("2. Silver");
		System.out.println("3. Gold");
		System.out.println("4. Platinum\n");
		
		// The instance of scanner class takes in user input regarding which type
		// of frequent flyer they are. They must enter a numeral which corresponds
		// to one of the options above or they will not receive any bonus miles.
		System.out.print("Enter frequent flyer status option (1-4): ");
		flyerStatus = scanner.nextLine();
		
		// Depending on corresponding user input, the user will receive a varying
		// amount of frequent flyer miles (due to the bonus they receive).
		// If they are a bronze flyer, their flyer miles are equal to the distance
		// traveled.
		// If they are a silver flyer, their flyer miles are equal to 125% of their
		// distance traveled.
		// If they are a gold flyer, their flyer miles are equal to 150% of their
		// distance traveled.
		// If they are a platinum flyer, their flyer miles are equal to 200% of their
		// distance traveled. 
		switch (flyerStatus) {
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
		
		System.out.print("\n");
		
		// Prints out the number of frequent flyer miles earned by flying from one
		// location to another for the user. 
		System.out.printf("You will earn %.2f miles flying from Phoenix to %s.", earnedMiles, destinationCode);
		
		
		
	}
}
