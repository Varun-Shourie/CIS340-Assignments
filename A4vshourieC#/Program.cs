using System;
using static System.Console;

namespace A4vshourie
{
    class ShoppingCart
    {
        static void Main(string[] args)
        {
            // Declares three arrays to store information about
            // the user's purchased products.
            string[] productName;
            string[] productCategory;
            double[] price;

            // Allocates five elements to arrays to represent
            // the number of items the user has purchased.
            productName = new string[5];
            productCategory = new string[5];
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

            // Welcomes the user to the program.
            WriteLine("\t\t\tShopping Cart\n\n");
            WriteLine("This program maintains a list of products" +
                " (name, category, price). It will calculate average dollars" +
                " spent per category for you.\n");

            // Traverses through the array to take in user input
            // regarding the product's name
            for (int i = 0; i < 5; i++)
            {
                // Takes in the product name.
                Write("Enter product name: ");
                productName[i] = ReadLine();
                // Takes in the product category.
                Write("Enter product category (Tech/Grocery/Office): ");
                productCategory[i] = ReadLine();
                productCategory[i] = productCategory[i].ToUpper();
                // Takes in the price of the product.
                Write("Enter product price: ");
                price[i] = Convert.ToDouble(ReadLine());
                // Keeps track of the sum of all prices entered for each category
                // and the number of items in each category. Converts all product
                // category input into upper case for uniformity in comparisons.
                switch(productCategory[i])
                {
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
                } // End switch
                WriteLine();
            } // End for

            // Traverses through the productCategory array to list out
            // all of the products which are tech products only.
            WriteLine("TECH PRODUCTS");
            for (int i = 0; i < 5; i++)
            {
                if(productCategory[i].Equals("TECH"))
                {
                    WriteLine(productName[i]);
                }
            } // end for

            // If any tech items were entered, then the average will be calculated.
            // The average of the prices = (total of all prices) / (total number of
            // items per category).
            // If no tech items were entered, then we assume that the average is 0.
            if(techItems != 0)
            {
                techPricesAvg = techPricesTotal / techItems;
                WriteLine("Average dollars spent: {0:C}", techPricesAvg);
            }
            else
            {
                WriteLine("Average dollars spent: {0:C}", 0.0);
            }
            WriteLine();

            // Traverses through the productCategory array
            // to list out all of the products which are
            // grocery products only.
            WriteLine("GROCERY PRODUCTS");
            for(int i = 0; i < 5; i++)
            {
                if (productCategory[i].Equals("GROCERY"))
                {
                    WriteLine(productName[i]);
                }
            } // end for

            // If any items were entered, then the avg will be calculated.
            // The average of the prices = (total of all prices) / (total number 
            // of items per category). If no grocery items were entered, then we 
            // assume that the average is zero. 
            if(groceryItems > 0)
            {
                groceryPricesAvg = groceryPricesTotal / groceryItems;
                WriteLine("Average dollars spent: {0:C}", groceryPricesAvg);
            }
            else
            {
                WriteLine("Average dollars spent: {0:C}", 0.0);
            }
            WriteLine();

            // Traverses through the productCategory array
            // to list out all of the products which are
            // office products only.
            WriteLine("OFFICE PRODUCTS");
            for (int i = 0; i < 5; i++)
            {
                if (productCategory[i].Equals("OFFICE"))
                {
                    WriteLine(productName[i]);
                }
            } // end for

            // If any items were entered, then the avg will be calculated.
            // The average of the prices = (total of all prices) / (total number 
            // of items per category). If no office items were entered, then we 
            // assume that the average is zero. 
            if (officeItems > 0)
            {
                officePricesAvg = officePricesTotal / officeItems;
                WriteLine("Average dollars spent: {0:C}", officePricesAvg);
            }
            else
            {
                WriteLine("Average dollars spent: {0:C}", 0.0);
            }
            WriteLine();

            // Traverses through the productCategory array
            // to list out all products which are unidentifiable products 
            WriteLine("OTHER");
            for(int i = 0; i < 5; i++)
            {
                if(!productCategory[i].Equals("TECH") &&
                    !productCategory[i].Equals("GROCERY") &&
                    !productCategory[i].Equals("OFFICE"))
                {
                    WriteLine(productName[i]);
                }
            }

            // If any items were entered, then the avg will be calculated.
            // The average of the prices = (total of all prices) / (total number 
            // of items per category). If no unidentified items were entered, then we 
            // assume that the average is zero. 
            if (otherItems > 0)
            {
                otherPricesAvg = otherPricesTotal / otherItems;
                WriteLine("Average dollars spent: {0:C}", otherPricesAvg);
            }
            else
            {
                WriteLine("Average dollars spent: {0:C}", 0.0);
            }
            WriteLine();
        }
    }
}
