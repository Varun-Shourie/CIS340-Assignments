using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace A8vshourie
{
    class Loan
    {

        // Various characteristics of a loan we are interested in. 
        private double loanAmount;
        private int numOfYears;
        private double annualInterestRate;

        // Only sets the interest rate to 5% because we assume this is a fixed quantity throughout program execution.
        public Loan()
        {
            annualInterestRate = 5.0;
        }

        // Same reasoning applies as above. 
        public Loan(double loanAmount, int numOfYears)
        {
            this.loanAmount = loanAmount;
            this.numOfYears = numOfYears;
            annualInterestRate = 5.0;
        }

        // Same reasoning applies as above.
        public Loan(int numOfYears, double loanAmount)
        {
            this.numOfYears = numOfYears;
            this.loanAmount = loanAmount;
            annualInterestRate = 5.0;
        }

        // Calculates the monthly payment for a user.
        public double CalculateMonthlyPayment()
        {
            double monthlyInterestRate = 0;
            double monthlyPayment = 0;

            // We must divide the annual interest rate (in percentage) by 12 months to get the monthly interest rate 
            // and then divide by 100 to convert the monthly interest rate into a decimal.
            monthlyInterestRate = annualInterestRate / 1200;

            // This is the formula taken verbatim as per organizational business rules.
            monthlyPayment = loanAmount * monthlyInterestRate / (1 - (Math.Pow(1 / (1 + monthlyInterestRate), numOfYears * 12)));

            return monthlyPayment;
        }

        // Calculates the total payment, which is simply the monthly payment multiplied by 12, to get the yearly payment.
        // The yearly payment is then multiplied by the number of the years to get the total.
        public double CalculateTotalPayment()
        {
            return CalculateMonthlyPayment() * 12 * numOfYears;
        }

        public double GetAnnualInterestRates()
        {
            return annualInterestRate;
        }

        public double GetLoanAmount()
        {
            return loanAmount;
        }

        public double GetNumOfYears()
        {
            return numOfYears;
        }

        public void SetAnnualInterestRate(double annualInterestRate)
        {
            this.annualInterestRate = annualInterestRate;
        }

        public void SetLoanAmount(double loanAmount)
        {
            this.loanAmount = loanAmount;
        }

        public void SetNumOfYears(int numOfYears)
        {
            this.numOfYears = numOfYears;
        }
    }
}
