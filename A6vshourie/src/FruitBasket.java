// A6, Varun Shourie, CIS340, Tuesday/Thursday, 3:00PM-4:15PM

import java.util.Scanner;

public class FruitBasket {
	
	// Instantiates a static scanner object for use throughout the program. 
	public static Scanner scanner = new Scanner(System.in);
	
	// Fields which indicate the attributes/contents of each fruit basket object.
	private Apple apple;
	private Banana banana;
	private String basketName;
	
	// Retrieves the basket name for the user. 
	public String getBasketName() {
		return this.basketName;
	}
	
	// Allows the user to alter the name of the fruit basket object.
	public void setBasketName(String basketName) {
		this.basketName = basketName;
	}
	
	// Creates instances/objects of type apple and banana and instantiates their attributes. 
	public void makeFruits() {
		
		// Instantiates an apple with radius of 1.5 inches & a banana object with length of 3.5 inches.
		apple = new Apple(1.5);
		banana = new Banana(3.5);
		
		// Alters the value of peel thickness for both of the fruit objects. 
		apple.setPeelThickness(1);
		banana.setPeelThickness(4);
	}
	
	// Informs the users that there is an apple and banana available, and allows them to consume
	// a portion of each fruit.
	public void eatFruits() {
		// Stores the portion of the fruit the user would like to consume. 
		double amountToEat = 0.0;
	
		// Prints the basket's name and information.
		System.out.printf("\t\t\t***%s***\n", this.basketName.toUpperCase());
		System.out.printf("You have an apple and a banana in your %s basket.\n", this.basketName);
		
		// Prompts the user for the amount of apple they would like to eat.
		System.out.print("What percent of the apple would you like to eat? ");
		amountToEat = Double.parseDouble(scanner.nextLine());
		// Physically consumes the apple by the amount the user has specified.
		apple.eat(amountToEat);
		
		// Prompts the user for the amount of banana they would like to eat.
		System.out.print("What percent of the banana would you like to eat? ");
		amountToEat = Double.parseDouble(scanner.nextLine());
		// Physically consumes the banana by the amount the user has specified. 
		banana.eat(amountToEat);
		
		System.out.println();
		
		// Lets the user know how much of the apple and banana is left.
		System.out.printf("You have %.2f of your apple and %.2f of your banana left in your"
				+ " %s basket.\n", apple.getPercentLeft(), banana.getPercentLeft(), this.basketName);
		
	}

	
}
