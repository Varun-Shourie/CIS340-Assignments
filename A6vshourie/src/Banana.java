// A6, Varun Shourie, CIS340, Tuesday/Thursday, 3:00PM-4:15PM

public class Banana {
	
	// Various attributes of a banana of interest to the user. 
	private double length;
	private int peelThickness;
	private double percentLeft;
	
//	public static void main(String[] args) {
//		Banana banana = new Banana(15.0);
//		
//		System.out.println(banana.length);
//		System.out.println(banana.peelThickness);
//		System.out.println(banana.percentLeft);
//	}
	
	// Initializes fields when no arguments/parameters are passed, returns memory address to an object.
	public Banana() {
		percentLeft = 100.0;
	}
	
	// Initializes fields when the length of the banana is passed as an argument, returns a memory address
	// to an object.
	public Banana(double length) {
		percentLeft = 100.0;
		setLength(length);
	}
	
	// Retrieves the length of the banana in an encapsulated fashion for the user.
	public double getLength() {
		return this.length;
	}
	
	// Allows the user to alter the length of the banana object.
	public void setLength(double value) {
		this.length = value;
	}
	
	// Retrieves the peel thickness value of the banana in an encapsulated fashion for the user.
	public int getPeelThickness() {
		return this.peelThickness;
	}
	
	// Allows the user to alter the peel thickness of the banana object.
	public void setPeelThickness(int value) {
		this.peelThickness = value;
	}
	
	// Allows the user to check how much of the fruit is left (not eaten).
	public double getPercentLeft() {
		return this.percentLeft;
	}
	
	// Allows the user to consume a certain portion of the banana object. 
	public void eat(double eatenAmount) {
		this.percentLeft = this.percentLeft - eatenAmount;
	}
}
