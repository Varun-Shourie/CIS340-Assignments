// A7, Varun Shourie, CIS340, Tuesday/Thursday, 3:00PM-4:15PM

import java.util.ArrayList;
import java.util.Scanner;

public class LibrarySystem {
	
	// This scanner object is later used in reading user input.
	Scanner scanner = new Scanner(System.in);
	
	// Stores a list of all books and their characteristics. 
	private Book temporaryBook;
	private ArrayList<Book> bookList;
	
	// Stores the count of books the user wishes to input. 
	private int bookCount;
	
	// This constructor only initializes the array list specially because the book object is temporary
	// and should be instantiated when a book is added.
	public LibrarySystem() {
		bookList = new ArrayList<>();
	}
	
	// Asks for information about one book and adds it to the ArrayList.
	public void addBook() {
		
		// Meant to store user input.
		String bookTitle = "";
		int publicationYear = 0;
		
		System.out.print("Enter Book Title: ");
		bookTitle = scanner.nextLine();
		
		System.out.print("Enter Book Year: ");
		publicationYear = Integer.parseInt(scanner.nextLine());
		
		temporaryBook = new Book(bookTitle, publicationYear);
		bookList.add(temporaryBook);
		System.out.printf("Title '%s' added to the library.\n", temporaryBook.getBookTitle());
	}
	
	// Loops through the ArrayList of books, displays books' names and publication year in a neat column.
	public void displayBookList() {
		displayHeader();
		System.out.printf("%-70s %-4s\n", "Book Title", "Year");
		
		for (Book b : bookList) {
			System.out.printf("%-70s %-4d\n", b.getBookTitle(), b.getPublicationYear());
		}
	}
	
	// Displays the title of the program.
	public void displayHeader() {
		System.out.print("\t\t\tNew Library System\n\n\n");
	}

	
	// Asks the user for the number of books needed, executes the menu, and displays the list of books.
	public void loadLibrarySystem() {
		displayHeader();
		 
		System.out.print("How many new books do you want to add to the Library? ");
		bookCount = Integer.parseInt(scanner.nextLine());
		System.out.println();
		
		// Allows the user to input as many books as they wish.
		for(int i = 0; i < bookCount; i++) {
			addBook();
		}
		System.out.println();
		
		System.out.println("Adding books complete. Press enter to continue.");
		
		// The .nextLine() is simply meant to take the user's enter key.
		scanner.nextLine();
		System.out.println();
		
		displayBookList();
		
		scanner.close();
	}
	
	// Physically executes the program by creating an object of this class.
	public static void main(String[] args) {
		LibrarySystem librarySystem = new LibrarySystem();
		librarySystem.loadLibrarySystem();
	}
	
}
