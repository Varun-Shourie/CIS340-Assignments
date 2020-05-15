using System;
using static System.Console;

namespace A1vshourie
{
    class TaxCalculator
    {
        static void Main(string[] args)
        {
            // Variables such as grossIncome and filingStatus
            // are meant to store user input for later calculations
            // The remaining variables are derived intermediate 
            // values in the calculations necessary to derive 
            // the final income tax, represented by incomeTax.
            // Business rules for calculations are shown below. 
            double grossIncome = 0.0;
            int taxDeduction = 0;
            double netIncome = 0.0;
            double federalTax = 0.0;
            double stateTax = 0.0;
            double incomeTax = 0.0;
            string filingStatus = "";

            // Welcomes and introduces user to the program.
            WriteLine("\t\t\tIncome Tax Calculator\n");
            WriteLine("This program allows you to determine your income taxes.\n");

            // Prompts the user to input their gross income
            // which can then be stored for later computation
            // (for values like net income). 
            Write("Please enter your gross income: ");
            grossIncome = Convert.ToDouble(ReadLine());

            Write("\n");

            // This provides options for the user to choose from 
            // tax filing statuses for their application. 
            WriteLine("IRS Filing Statuses in Applications: ");
            WriteLine("Single - SG");
            WriteLine("Married, Filing Jointly - MJ");
            WriteLine("Married, Filing Separately - MS");
            WriteLine("Head of household - HH\n");

            // Prompts the user to input the option from the filing
            // statuses which best matches their application.
            Write("Enter your two letter filing status: ");
            filingStatus = ReadLine();

            WriteLine("\n");

            // The switch statement allows us to determine tax
            // deductions from the user inputted filing status.
            // If single, the user is eligible for a $5950 deduction.
            // If married, and filing jointly, the user is eligible
            // for a $11900 deduction.
            // If married, and filing separately, the user is eligible 
            // for a $5950 deduction.
            // If head of the household, the user is eligible for a 
            // $8700 deduction.
            // If the user input does not match one of the options above,
            // then the user will not receive a tax deduction. 
            switch (filingStatus)
            {
                case "SG":
                    taxDeduction = 5950;
                    break;
                case "MJ":
                    taxDeduction = 11900;
                    break;
                case "MS":
                    taxDeduction = 5950;
                    break;
                case "HH":
                    taxDeduction = 8700;
                    break;
                default:
                    taxDeduction = 0;
                    break;
            }

            // A person's net income is derived through subtracting 
            // eligible tax deductions from their reported gross income.
            netIncome = grossIncome - taxDeduction;

            // Our federal income tax system allows for people
            // to pay different rates. Here are the rules:
            // If a person makes below $30k, they pay no taxes on income.
            // If a person's salary is $30k or above and below $60k,
            // they pay 10% of their income.
            // If they make 60k or above but they make less than 100k,
            // they pay 20% of their income.
            // If they make 100k or above but they make less than 250k,
            // they pay 30% of their income.
            // If they make 250k or above, they pay 40% of income.

            if (netIncome < 30000)
            {
                federalTax = netIncome * 0.0;
            }
            else if (netIncome >= 30000 && netIncome < 60000)
            {
                federalTax = netIncome * 0.1;
            }
            else if (netIncome >= 60000 && netIncome < 100000)
            {
                federalTax = netIncome * 0.2;
            }
            else if (netIncome >= 100000 && netIncome < 250000)
            {
                federalTax = netIncome * 0.3;
            }
            else if (netIncome >= 250000)
            {
                federalTax = netIncome * 0.4;
            }

            // The state tax is derived by multiplying a person's
            // net income by 2.5%.
            stateTax = netIncome * 0.025;

            // The final income tax is derived by adding the 
            // federal tax amount plus state tax amount
            incomeTax = federalTax + stateTax;

            // Reminds the user what they stated their gross income was. 
            WriteLine("Your stated income is {0:c}", grossIncome);


            // Outputs the final calculated income tax liability sum 
            // based on the gross income given, filing code, and 
            // calculations performed above. 
            WriteLine("Your final tax liability is {0:c}", incomeTax);


        }
    }
}
