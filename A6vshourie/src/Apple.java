// A6, Varun Shourie, CIS340, Tuesday/Thursday, 3:00PM-4:15PM

public class Apple {
	
	// Fields which describe the characteristics of an object of type Apple.
	private int peelThickness;
	private double percentLeft;
	private double radius;
	
	public static void main(String[] args) {
		Apple apple = new Apple();
		System.out.println(apple.peelThickness);
		System.out.println(apple.percentLeft);
		System.out.println(apple.radius);
	}
	
	// Initializes fields of the Apple object when no arguments are provided & returns memory address of object.
	public Apple() {
		percentLeft = 100.0;
	}
	
	// Initializes fields of the Apple object when the radius is provided as a parameter/argument &
	// returns memory address of object.
	public Apple(double radius) {
		percentLeft = 100.0;
		setRadius(radius);
	}
	
	// Retrieves the peel thickness for the user.
	public int getPeelThickness() {
		return peelThickness;
	}
	
	// Allows the user to alter the value of the peel thickness for the apple object.
	public void setPeelThickness(int value) {
		this.peelThickness = value;
	}
	
	// Allows the user to retrieve the amount of the apple left to be eaten.
	public double getPercentLeft() {
		return percentLeft;
	}
	
	// Allows the user to retrieve the radius of the apple object.
	public double getRadius() {
		return radius;
	}
	
	// Allows the user to alter the radius of the apple object.
	public void setRadius(double value) {
		this.radius = value;
	}
	
	// Allows the user to consume the apple object, thereby reducing the amount left by the amount consumed.
	public void eat (double eatenAmount) {
		this.percentLeft = percentLeft - eatenAmount;
	}
}
