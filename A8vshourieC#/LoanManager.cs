using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace A8vshourie
{
    class LoanManager
    {

        // Stores information about all loans and the number of loans in the system.
        Loan tmpLoan;
        Loan[] loans;
        int numberOfLoans;

        // Only instantiates the array of loans because loan objects are temporary and will be instantiated
        // as the program executes. 
        public LoanManager()
        {
            loans = new Loan[10];
        }

        public void ApplyForLoan()
        {
            string applyMoreLoans = "";
            double loanAmount = 0.0;
            int loanYears = 0;

            // The loan number starts at zero to account for the correct index in the array.
            numberOfLoans = 0;

            do
            {
                // This if clause exists to ensure the array index does not go out of bounds, leaving the app stable.
                if(numberOfLoans == 10)
                {
                    Write("Maximum amount of loans reached.\nPlease enter a key to stop the prompt.");
                    ReadLine();
                    WriteLine();
                    return;
                }

                tmpLoan = new Loan();

                loanAmount = ReadLoanAmount("Enter loan amount: ");
                tmpLoan.SetLoanAmount(loanAmount);

                loanYears = ReadLoanYears("Enter number of years: ");
                tmpLoan.SetNumOfYears(loanYears);

                WriteLine("The total payment on this loan will be: {0:c}\n", tmpLoan.CalculateTotalPayment());

                loans[numberOfLoans] = tmpLoan;

                numberOfLoans++;

                applyMoreLoans = ReadUserPreference("Do you want to apply for another loan? (Y/N): ", "Y", "N");

                // In the case that the program experiences a very unlikely logic error as shown in the applyMoreLoans
                // method, the program will immediately stop. 
                if (applyMoreLoans.Equals("-1"))
                {
                    WriteLine("A fatal error has occurred in the program. Please press a key to exit the program.");
                    ReadLine();
                    Environment.Exit(-1);
                }

            } while (applyMoreLoans.Equals("Y", StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayHeader()
        {
            Write("\t\t\tFirst National Loans\n\n\n");
        }
        
        public void DisplayLoans()
        {
            double totalPayment = 0;

            WriteLine("Following are the loans in the system.");
            WriteLine("{0,-20} {1,-25}", "Amount", "Total Payment");

            for (int i = 0; i < numberOfLoans; i++)
            {
                WriteLine("{0,-20} {1,-25}", loans[i].GetLoanAmount().ToString("0.00"), 
                    loans[i].CalculateTotalPayment().ToString("0.00"));
                totalPayment += loans[i].CalculateTotalPayment();
            }

            Write("\n");
            WriteLine("The total payment of all loans is {0:c}", totalPayment);
        }

        public void ExecuteMenu()
        {
            DisplayHeader();
            ApplyForLoan();
            DisplayLoans();
        }

        public static void Main(string[] args)
        {
            LoanManager loanManager = new LoanManager();
            loanManager.ExecuteMenu();
        }
     
        public double ReadLoanAmount(string displayPrompt)
        {
            int numberOfErrors = 0;
            double loanAmount = 0;

            bool repeatInput = false;

            // Keeps track of the number of times the user makes an error in input.
            do
            {
                try
                {
                    Write(displayPrompt);
                    loanAmount = Convert.ToDouble(ReadLine());

                    // Set false only in case the user input is valid.
                    repeatInput = false;
                }
                catch (FormatException fe)
                {
                    if (numberOfErrors == 2)
                    {
                        WriteLine("User has made too many errors in entering data. Please enter a key to exit.");
                        ReadLine();

                        Environment.Exit(0);
                    }
                    else
                    {
                        WriteLine("\nThe loan amount must be a valid floating point decimal. Try again.\n");

                        // set to true to suggest the user has made a mistake and should try again.
                        repeatInput = true;
                        numberOfErrors++;
                    }
                }
            } while (repeatInput);

            return loanAmount;
        }

        public int ReadLoanYears(string displayPrompt)
        {
            int numberOfErrors = 0;
            int loanYears = 0;

            bool repeatInput = false;

            // Keeps track of the number of errors a user makes in providing user input.
            do
            {
                try
                {
                    Write(displayPrompt);
                    loanYears = Convert.ToInt32(ReadLine());

                    // The loop doesn't have to continue if the user input is valid. 
                    repeatInput = false;
                }
                catch (FormatException fe)
                {
                    if(numberOfErrors == 2)
                    {
                        WriteLine("User has made too many errors in entering data. Please enter a key to exit.");
                        ReadLine();

                        Environment.Exit(0);
                    }

                    else
                    {
                        WriteLine("\nThe amount of years must be a valid integer. Try again.\n");

                        // If the user makes a mistake, the loop must occur again to give the user another chance.
                        repeatInput = true;
                        numberOfErrors++;
                    }
                }
            } while (repeatInput);

            return loanYears;
        }

        // Takes in user input regarding their preference using a generic prompt. 
        public string ReadUserPreference(string displayPrompt, string inputOfYes, string inputOfNo)
        {
            int numberOfErrors = 0;
            string userInput = "";

            // Allows users to make a maximum of three errors on user input. 
            do
            {
                Write(displayPrompt);
                userInput = ReadLine();

                if(userInput.Equals(inputOfYes, StringComparison.OrdinalIgnoreCase))
                {
                    Write("\n");
                    return userInput;
                }
                else if(userInput.Equals(inputOfNo, StringComparison.OrdinalIgnoreCase))
                {
                    Write("\n");
                    return userInput;
                }
                else
                {
                    if(numberOfErrors == 2)
                    {
                        WriteLine("\n\nUser has made too many errors in entering data. Please enter a key to exit.");
                        ReadLine();
                        Environment.Exit(0);
                    }

                    Write("\nInput must be '{0}' or '{1}'. Try again\n", inputOfYes, inputOfNo);
                    numberOfErrors++;
                }

            } while ( (!userInput.Equals(inputOfYes, StringComparison.OrdinalIgnoreCase)) && 
            (!userInput.Equals(inputOfNo, StringComparison.OrdinalIgnoreCase)) );

            // The method should never reach this return statement due to the logic planned out. If it does,
            // this is a flag for a logic error. Also, this return statement satisfies the compiler.
            return "-1";
        }




    }
}
