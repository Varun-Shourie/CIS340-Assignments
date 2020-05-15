using System;
using static System.Console;

namespace A3vshourie
{
    class Loops
    {
        static void Main(string[] args)
        {
            // Counter variable for the while loop in part 2.
            int counter = 1;
            // Captures user input for the number which the
            // user wishes to calculate factorials on in part 3.
            int userInputtedNumber = 0;
            // Default value for factorial calculation since 
            // all multiplication by 0 results in zero.
            int factorial = 1;
            // Used to take in user input and calculate the average
            // of scores for all students in part 5.
            int score = 0;
            int accumulatedTotal = 0;
            int countOfScores = 0;
            double average = 0;

            WriteLine("Part 1 - Odd Numbers");
            // Counter variable is initialized at 1 and incremented
            // by 2, resulting in the printing out of only odd numbers.
            for(int i = 1; i < 21; i += 2)
            {
                Write("{0} ", i);
            } // end for

            WriteLine();
            WriteLine();

            WriteLine("Part 2 - Even Numbers");
            // Lists all even numbers from 1 to 20 on the console.
            // The counter variable starts at 1 and is incremented by 1.
            // If the counter divides evenly into 2, then it is an even
            // number and is printed in the 20 iterations.
            while(counter <= 20)
            {
                if (counter % 2 == 0)
                    Write("{0} ", counter);
                counter++;
            } // end while

            WriteLine();
            WriteLine();

            // Prompts the user for a number whose factorial will be calculated.
            WriteLine("Part 3 - Factorial");
            Write("Enter a number for the factorial: ");
            userInputtedNumber = Convert.ToInt32(ReadLine());

            // Factorial is then calculated by multiplying all
            // integers from 1 to n (number).
            // This is modeled by looping calculations in a manner
            // which the default factorial value is multiplied by all
            // integers in reverse order with every iteration of the loop.
            for(int i = userInputtedNumber; i > 0; i--)
                factorial *= i;

            WriteLine("The factorial is {0}", factorial);
            WriteLine();
            WriteLine();

            // Prints out a special triangle pattern.
            // Outer loop determines the number of asterisks in 
            // each successive level (row).
            // Inner loop prints asterisks in the necessary
            // columns in each row.
            WriteLine("Part 4 - Triangle");
            for(int i = 10; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Write("*");
                }
                WriteLine();
            }

            WriteLine();
            WriteLine();

            // Asks the user to enter 2 scores each for 3 students.
            WriteLine("Part 5 - Average Calculator\n");
            WriteLine("This program will ask you to enter 2 scores " +
                "each for 3 students\n");
            // Nested for loop keeps track of which scores belong to
            // each student.
            // Outer for loop determines the number of the student.
            // Inner for loop determines the number of the quiz score
            // when taking in user input.. 
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Write("Student {0} - enter score {1}: ", (i + 1), (j + 1));
                    score = Convert.ToInt32(ReadLine());
                    // keeps track of the accumulated total of all scores.
                    accumulatedTotal += score;
                    // keeps track of the total number of scores. 
                    countOfScores++;
                }
            }

            WriteLine();
            WriteLine();

            // Calculates the average, which is the total of all scores
            // divided by the total number of scores.
            average = (double) accumulatedTotal / countOfScores;
            Write("The average of all scores is {0:0.00}\n\n", average);

            // Shows the multiplication tables of numbers 5 through 10 multiplied
            // multiplied by 10, 20, 30, 40, and 50.
            // Outer loop loops through the numbers 5 through 10.
            // Inner loop loops through 10, 20, 30, 40, 50.
            // Through nested loops we can print the multiplication table which
            // results when the outer loop iteration counter is multiplied
            // by the inner loop iteration counter.
            WriteLine("Part 6 - Multiplication Tables");
            for(int i = 5; i < 11; i++)
            {
                for (int j = 10; j < 60; j += 10)
                    Write("{0, 2} * {1, 2} = {2, 5}\n", i, j, (i * j));
            }
            WriteLine();
        }
    }
}
