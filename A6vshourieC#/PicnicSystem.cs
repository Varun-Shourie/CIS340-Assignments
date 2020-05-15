using System;
using System.Collections.Generic;
using System.Text;

namespace A6vshourie
{
    class PicnicSystem
    {
        // Physically executes the program.
        public static void Main(string[] args)
        {
            PicnicSystem myPicnicSystem = new PicnicSystem();
            myPicnicSystem.MakeFruitBaskets();
        }

        // Creates and instantiates fruit baskets containing apples and bananas for the user to "consume."
        private void MakeFruitBaskets()
        {
            FruitBasket basket1 = new FruitBasket();
            FruitBasket basket2 = new FruitBasket();

            basket1.SetBasketName("Weekend");
            basket2.SetBasketName("Weekday");

            basket1.MakeFruits();
            basket1.EatFruits();

            basket2.MakeFruits();
            basket2.EatFruits();
        }
    }
}
