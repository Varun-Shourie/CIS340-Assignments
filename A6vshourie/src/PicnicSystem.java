// A6, Varun Shourie, CIS340, Tuesday/Thursday, 3:00PM-4:15PM

public class PicnicSystem {
	public static void main(String[] args) {
		
		// Declares, instantiates an instance of the PicnicSystem class.
		PicnicSystem myPicnicSystem = new PicnicSystem();
		// Allows the program to make a fruit basket and let the user consume the fruit objects. 
		myPicnicSystem.makeFruitBaskets();
	}
	
	// Creates & instantiates fruit baskets for the user to "consume."
	private void makeFruitBaskets() {
		// Declares variables representing two fruit basket objects.
		FruitBasket basket1;
		FruitBasket basket2;
		
		// Physically creates the basket objects. 
		basket1 = new FruitBasket();
		basket2 = new FruitBasket();
		
		// Alters the name of the basket objects.
		basket1.setBasketName("Weekend");
		basket2.setBasketName("Weekday");
		
		// Creates the fruit objects with instantiated fields and allows the user to eat 
		// an apple and banana object. 
		basket1.makeFruits();
		basket1.eatFruits();
		basket2.makeFruits();
		basket2.eatFruits();
		
		FruitBasket.scanner.close();
	}

}
