// A5, Varun Shourie, CIS340, Tuesday/Thursday, 3:00PM-4:15PM.

import java.util.Scanner; 

public class GradeSystem {
	// Instantiates an object of type Scanner for storing user input.
	static Scanner scanner = new Scanner(System.in);
	
	// Declares two arrays to store scores and names. 
	static int[] scoreArray;
	static String[] nameArray;
	
	// Prompts the user to enter names and stores the names in the names array.
	private static void populateNameArray() {
		
		// Prompts user to enter names.
		System.out.println("************************************");
		System.out.printf("Enter the names of %d students.\n", nameArray.length);
		System.out.println("************************************\n");
		
		// Traverses through the names array and stores all names in the names array. 
		for(int i = 0; i < nameArray.length; i++) {
			nameArray[i] = scanner.nextLine();
		}
	}
	
	// Prompts the user for and reads 5 student scores. 
	private static void populateScoreArray() {
		
		// Prompts the user to enter scores for the students. 
		System.out.println("************************************");
		System.out.println("Enter scores. One score per line. ");
		System.out.println("************************************\n");
		
		// Further prompts the user and traverses through the scores array 
		// to store scores for all students.
		for(int i = 0; i < scoreArray.length; i++) {
			System.out.printf("Enter score for %s: ", nameArray[i]);
			scoreArray[i] = Integer.parseInt(scanner.nextLine());
		}
	}
	
	// Finds and returns the location of a student in the names array.
	private static int findStudentPosition(String nameOfStudent) {
		// Loops through all the students to cross-reference the 
		// name with stored values. 
		for(int i = 0; i < nameArray.length; i++) {
			// If a match is found, the location value is returned.
			if(nameOfStudent.equalsIgnoreCase(nameArray[i]))
				return i;
		}
		
		// If a match is not found, then a -1 is returned to symbolize an error. 
		return -1;
	}
	
	public static void main(String[] args) {
		
		// Stores the user's desired student name and position number.
		String studentName = "";
		int studentPosition = 0;
		
		// Allocates five elements to the scores and names array. 
		scoreArray = new int[5];
		nameArray = new String[5];
		
		// Welcomes the user to the program. 
		System.out.println("\t\t\t\tStudent Grade System\n");
		System.out.println("This program will store student grades "
				+ "and look them up for you.\n");
		
		// Populates the names array with names inputted by the user for each student.
		populateNameArray();
		
		System.out.println("\n\n\n");
		
		// Populates the score array with scores inputted by the user for each student.
		populateScoreArray();
		
		System.out.println("\n\n\n");
		
		// Prompts for and takes in user input regarding the student the user wishes to find. 
		System.out.print("Enter name of student whose score you want to find: ");
		studentName = scanner.nextLine();
		
		// Retrieves the position of the student in the names array for later 
		// referencing the student score. 
		studentPosition = findStudentPosition(studentName);
		
		// If there was an error in finding the student's position, the program notifies the
		// user. If not, the program retrieves and displays the student's name and score. 
		if(studentPosition == -1) {
			System.out.println("");
			System.out.println("A student by that name does not exist in the database.");
		}
		else {
			System.out.printf("%s's score is %d", nameArray[studentPosition], 
					scoreArray[studentPosition]);
		}
		
		scanner.close();
	}
}
