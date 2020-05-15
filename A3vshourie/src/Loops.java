// A3, Varun Shourie, CIS340, Tuesday/Thursday 3:00PM-4:15PM

import java.util.Scanner;

public class Loops {
	public static void main(String[] args) {
		
		// This variable is a counter variable for the while loop below;
		// It is declared and initialized at 1 as per assignment rules. 
		int counter = 1;
		// This variable captures user input for part 3, where the factorial is calculated.
		int userInputtedNumber = 0;
		// To start with factorial calculations, we cannot store the initial value as 0.
		// We must keep a one if multiplications are to not result in zero when multiplied
		// by other factors in a loop. 
		int factorial = 1;
		// These variables below are used to take in user input for student scores 
		// and determine the averages of the student scores inputted by the user.
		int score = 0;
		int accumulatedTotal = 0;
		int countOfScores = 0;
		double average = 0;
		
		// Initializes an instance of scanner to be used in later code.
		Scanner scanner = new Scanner(System.in);
		
		// Using a for loop, I will list all odd numbers from 1 to 20 on the console window.
		// The counter variable is initialized at 1 and incremented by two
		// resulting in the printing out of only odd numbers and fewer iterations.
		System.out.println("Part 1 - Odd Numbers");
		for(int i = 1; i < 21; i += 2) {
			System.out.printf("%d ", i);
		} // end for 
		
		System.out.println();
		System.out.println();
		
		// Lists all even numbers from 1 to 20 on the console window. 
		// The counter variable starts at 1 and is incremented by 1.
		// If the counter divides evenly into 2, then it is a even
		// number and thus is printed in the corresponding iteration.
		System.out.println("Part 2 - Even Numbers");
		while(counter <= 20) {
			if(counter % 2 == 0) {
				System.out.printf("%d ", counter);
			}
			
			counter++;
		} // end while 
		
		System.out.println();
		System.out.println();
		
		// Prompts the user for a number and calculates the factorial for the number.
		System.out.println("Part 3 - Factorial");
		System.out.print("Enter a number for the factorial: ");
		userInputtedNumber = Integer.parseInt(scanner.nextLine());
		
		// The factorial can be calculated by multiplying all the integers from 1 to (number).
		// The factorial here is calculated by looping calculations -- the counter variable is decremented
		// by 1 while the factorial value is multiplied by the counter in descending order,
		// modeling how factorials are multiplied in real life. 
		for(int i = userInputtedNumber; i > 0; i--) {
			factorial *= i;
		}
		System.out.println("The factorial is " + factorial);
		System.out.println();
		System.out.println();
		
		// Prints out a special triangle pattern.
		// The outer loop is responsible for the determining the number of 
		// of asterisks in each successive level (row).
		// The inner loop prints asterisks in the necessary columns in each row. 
		System.out.println("Part 4 - Triangle");
		for(int i = 10; i > 0; i--) {
			for(int j = i; j > 0; j--) {
				System.out.print("*");
			}
			System.out.println();
		}
		
		System.out.println();
		System.out.println();
		
		// Asks the user to enter 2 scores each for 3 students. 
		System.out.println("Part 5 - Average Calculator\n");
		System.out.println("This program will ask you to enter 2 scores each for 3 students\n");
		// Nested for loop keeps track of which scores belong to each student.
		// The outer for loop determines the number of the student when taking in user input.
		// The inner for loop determines the number of the score when taking in user input. 
		for(int i = 0; i < 3; i++) {
			for(int j = 0; j < 2; j++) {
				System.out.printf("Student %d - enter score %d: ", (i+1), (j+1));
				score = Integer.parseInt(scanner.nextLine());
				// keeps track of the accumulated totals of all scores for average calculations.
				accumulatedTotal += score;
				// keeps track of the total number of scores inputted for average calculations.
				countOfScores++;
			}
		}
		System.out.println();
		System.out.println();
		
		// Calculates the average, which is the total of all the scores divided by the total 
		// amount of scores taken, which is 6;
		average = (double) accumulatedTotal / countOfScores;
		System.out.printf("The average of all scores is %.2f\n\n", average);
		
		// Shows the multiplication tables of the numbers 5 through 10 multiplied by the 
		// following five numbers: 10, 20, 30, 40, 50.
		// The outer loop loops through all the iterations of the numbers 5, 6, 7, 8, 9, and 10
		// THe inner loop loops through all the iterations of the second multiple in the 
		// expression; this means the inner loop will loop through 10, 20, 30, 40, and 50.
		// Through the use of the nested loop, we can print out the value of the current 
		// iteration of the outer loop being multiplied by the value of the current 
		// iteration of the inner loop, resulting in the multiplication table. 
		System.out.println("Part 6 - Multiplication Table\n");
		for(int i = 5; i < 11; i++) {
			for(int j = 10; j < 60; j += 10) {
				System.out.printf("%2d * %2d = %5d\n", i, j, (i*j));
			}
			System.out.println();
		}
		
		
		scanner.close();
	}
}
