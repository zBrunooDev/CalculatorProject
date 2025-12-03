using System;

namespace CalculatorProject
{
    public class CalculatorService
    {
        // Class responsible for the calculation os the operations

        public double SimpleInterestCalculater(double initialCapital, double interestRate, double aplicationTime)
        {
            double amount = initialCapital * (1 + interestRate * aplicationTime);
            return amount;
        }

        public double CompoundInterestCalculater(double initialCapital, double interestRate, double aplicationTime)
        {
            double amount = initialCapital * Math.Pow((1 + interestRate), aplicationTime);
            return amount;
        }

        public double EconomiaMensalCalculater(double montlhlyAmount, double totalExpense)
        {
            double MonthlySavings = totalExpense - montlhlyAmount;
            return MonthlySavings;
        }

    }
}