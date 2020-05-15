// A7, Varun Shourie, CIS340, Tuesday/Thursday, 3:00PM-4:15PM

public class Book {
	
	// Characteristics of a book which are of interest to the end-user. 
	private String bookTitle;
	private int publicationYear;
	
	// This constructor is in place for the contingency the user does not provide any arguments at all.
	public Book() {
		
	}
	
	// Uses the setter since the library system must comply with the business rules shown. Refer to the
	// setter method for the business rules.
	public Book(String bookTitle, int publicationYear) {
		setBookTitle(bookTitle);
		setPublicationYear(publicationYear);
	}
	
	// Uses the setter since the library system must comply with the business rules shown. Refer to the
	// setter method for the business rules.
	public Book(int publicationYear, String bookTitle) {
		setPublicationYear(publicationYear);
		setBookTitle(bookTitle);
	}
	
	public String getBookTitle() {
		return bookTitle;
	}
	
	public int getPublicationYear() {
		return publicationYear;
	}
	
	public void setBookTitle(String bookTitle) {
		this.bookTitle = bookTitle;
	}
	
	// Mutates the value of the publication year according to the library's specified business rules:
	// a book can only have a published date between 1100 and 2017. If this is not fulfilled, then 
	// the book automatically has a publication year of 1900.
	public void setPublicationYear(int publicationYear) {
		if(publicationYear >= 1100 && publicationYear <= 2017)
			this.publicationYear = publicationYear;
		else 
			this.publicationYear = 1900;
	}
	
}
