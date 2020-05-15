using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace A6vshourie
{
    class FruitBasket
    {
        // Store the modeled contents of each fruit basket.
        private Apple apple;
        private Banana banana;
        private string basketName;

        public string GetBasketName()
        {
            return basketName;
        }

        public void SetBasketName(string basketName)
        {
            this.basketName = basketName;
        }

        // Creates modeled apples and bananas and modifies their attributes.
        public void MakeFruits()
        {
            // The arguments provided refer to the length of the fruit.
            apple = new Apple(1.5);
            banana = new Banana(3.5);

            apple.SetPeelThickness(1);
            banana.SetPeelThickness(4);
        }

        // Informs the users of an apple and banana available to consume & allows them to consume a portion of the fruit.
        public void EatFruits()
        {
            // Stores the portion of the fruit the user would like to consume.
            double amountToEat = 0.0;

            Write("\t\t\t***{0}***\n", basketName.ToUpper());
            Write("You have an apple and a banana in your {0} basket.\n", basketName);

            Write("What percent of the apple would you like to eat? ");
            amountToEat = Convert.ToDouble(ReadLine());

            apple.Eat(amountToEat);

            Write("What percent of the banana would you like to eat? ");
            amountToEat = Convert.ToDouble(ReadLine());

            banana.Eat(amountToEat);

            Write("\n");

            Write("You have {0:0.00}% of your apple and {1:0.00}% of your banana left in your" +
                " {2} basket.\n\n", apple.GetPercentLeft(), banana.GetPercentLeft(), basketName);
        }
    }
}
