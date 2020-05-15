// A4, Varun Shourie, CIS340, Tuesday/Thursday, 3:00PM-4:15PM

import java.util.Scanner;

public class ShoppingCart {
	public static void main(String[] args) {
		
		// Declares three arrays to store information about
		// the user's purchased products.
		String[] productName;
		String[] productCategory;
		double[] price;
		
		// Allocates five elements to arrays to represent
		// the number of items the user has purchased.
		productName = new String[5];
		productCategory = new String[5];
		price = new double[5];
		
		// Series of variables meant to store the total
		// of prices, the count of the items, and the 
		// average of the prices for each product category.
		double techPricesTotal = 0.0;
		double groceryPricesTotal = 0.0;
		double officePricesTotal = 0.0;
		double otherPricesTotal = 0.0;
		int techItems = 0;
		int groceryItems = 0;
		int officeItems = 0;
		double otherItems = 0.0;
		double techPricesAvg = 0.0;
		double groceryPricesAvg = 0.0;
		double officePricesAvg = 0.0;
		double otherPricesAvg = 0.0;
		
		// Instantiates an object of the scanner class to take
		// in keyboard input.
		Scanner scanner = new Scanner(System.in);
		
		// Welcomes the user to the program.
		System.out.println("\t\t\tShopping Cart\n\n");
		System.out.println("This program maintains a list of products (name, category, price)."
				+ " It will calculate average dollars spent per category for you.\n");
		
		// Traverses through the arrays to take in user input
		// regarding the product's name, category, and price.
		for(int i = 0; i < 5; i++) {
			// Takes in the product name.
			System.out.print("Enter product name: ");
			productName[i] = scanner.nextLine();
			// Takes in the product category.
			System.out.print("Enter product category (Tech/Grocery/Office): ");
			productCategory[i] = scanner.nextLine();
			// Takes in the price of the product.
			System.out.print("Enter product price: ");
			price[i] = Double.parseDouble(scanner.nextLine());
			// Keeps track of the sum of all prices entered for each 
			// category and the number of items in each category.
			// Converts all product category input into upper case
			// for uniformity and consistency in comparisons.
			switch (productCategory[i].toUpperCase()) {
			case "TECH":
				techPricesTotal += price[i];
				techItems++;
				break;
			case "GROCERY":
				groceryPricesTotal += price[i];
				groceryItems++;
				break;
			case "OFFICE":
				officePricesTotal += price[i];
				officeItems++;
				break;
			default:
				otherPricesTotal += price[i];
				otherItems++;
				break;
			}
	
			System.out.println();
		}
		
		// Traverses through the productCategory array
		// to list out all of the products which are 
		// tech products only. 
		System.out.println("TECH PRODUCTS");
		for (int i = 0; i < 5; i++) {
			if(productCategory[i].equalsIgnoreCase("TECH")) {
				System.out.println(productName[i]);
			}
		}
		// If any tech items were entered, then the average will be calculated.
		// The average of the prices is calculated by taking the total of all prices
		// and dividing it by the total number of items in the category.
		// If no tech items were entered, then we assume that the average is 0.0
		// since the total prices entered equal zero. 
		if(!(techItems == 0)) {
			techPricesAvg = techPricesTotal / techItems;
			System.out.printf("Average dollars spent: $%.2f\n", techPricesAvg);
		}
		else {
			System.out.printf("Average dollars spent: $%.2f\n", 0.0);
		}
		System.out.println();
		
		// Traverses through the productCategory array
		// to list out all of the products which are 
		// grocery products only. 
		System.out.println("GROCERY PRODUCTS");
		for (int i = 0; i < 5; i++) {
			if(productCategory[i].equalsIgnoreCase("GROCERY")) {
				System.out.println(productName[i]);
			}
		}
		// If any grocery items were entered, then the average will be calculated.
		// The average of the prices is calculated by taking the total of all prices
		// and dividing it by the total number of items in the category.
		// If no grocery items were entered, then we assume that the average is 0.0
		// since the total prices entered equal zero. 
		if((groceryItems > 0)) {
			groceryPricesAvg = groceryPricesTotal / groceryItems;
			System.out.printf("Average dollars spent: $%.2f\n", groceryPricesAvg);
		}
		else {
			System.out.printf("Average dollars spent: $%.2f\n", 0.0);
		}		
		System.out.println();
		
		// Traverses through the productCategory array
		// to list out all of the products which are 
		// office products only. 
		System.out.println("OFFICE PRODUCTS");
		for (int i = 0; i < 5; i++) {
			if(productCategory[i].equalsIgnoreCase("OFFICE")) {
				System.out.println(productName[i]);
			}
		}
		// If any office items were entered, then the average will be calculated.
		// The average of the prices is calculated by taking the total of all prices
		// and dividing it by the total number of items in the category. 
		// If no office items were entered, then we assume that the average is 0.0
		// since the total prices entered equal zero. 
		if(officeItems > 0) {
			officePricesAvg = officePricesTotal / officeItems;
			System.out.printf("Average dollars spent: $%.2f\n", officePricesAvg);
		}
		else {
			System.out.printf("Average dollars spent: $%.2f\n", 0.0);
		}
		System.out.println();
		
		// Traverses through the productCategory array
		// to list out all of the products which are 
		// unidentifiable products only. 
		System.out.println("OTHER");
		for (int i = 0; i < 5; i++) {
			if(!productCategory[i].equalsIgnoreCase("TECH") &&
					!productCategory[i].equalsIgnoreCase("GROCERY") &&
					!productCategory[i].equalsIgnoreCase("OFFICE")) {
				System.out.println(productName[i]);
			}
		}
		// If any unidentified items were entered, then the average will be calculated.
		// The average of the prices is calculated by taking the total of all prices
		// and dividing it by the total number of items in the category.
		// If no unidentified items were entered, then we assume that the average is 0.0
		// since the total prices entered equal zero. 
		if(otherItems > 0) {
			otherPricesAvg = otherPricesTotal / otherItems;
			System.out.printf("Average dollars spent: $%.2f\n", otherPricesAvg);
		}
		else {
			System.out.printf("Average dollars spent: $%.2f\n", 0.0);
		}
		
		scanner.close();
	}
}
