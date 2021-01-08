using System;

namespace AssignInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int LoanTime;
            double InterestRate, LoanAmount, totalAmount;
            try
            {
                Console.WriteLine("Enter Name: ");
                Name = Convert.ToString(Console.ReadLine());
                while (string.IsNullOrEmpty(Name))
                {
                    Console.Write("Name can't be empty! Enter your name again: ");
                    Name = Console.ReadLine();
                }
                Console.WriteLine("Enter Loan Amount: ");
                var AmountString = Console.ReadLine();
                while (!double.TryParse(AmountString, out LoanAmount))
                {
                    Console.Write("Amount must be a numerical value, enter Loan Amount again: ");
                    AmountString = Console.ReadLine();
                }
                Console.WriteLine("Enter Loan Period (in years): ");
                var TimeString = Console.ReadLine();
                while (!int.TryParse(TimeString, out LoanTime))
                {
                    Console.Write("Amount must be a numerical value, enter Loan Period (in years) again: ");
                    TimeString = Console.ReadLine();
                }
                Console.WriteLine("Enter Interest Rate: ");
                var InterestString = Console.ReadLine();
                while (!double.TryParse(InterestString, out InterestRate))
                {
                    Console.Write("Rate must be a numerical value, enter Interest Rate again: ");
                    InterestString = Console.ReadLine();
                }
                totalAmount = CalcInterest(LoanAmount, LoanTime, InterestRate);
                Console.WriteLine($"{Name}: Total Amount is {totalAmount}");
            }
            catch(FormatException ex1)
            {
                Console.WriteLine("Invalid input format...{0}", ex1.Message);
            }
            catch(Exception ex2)
            {
                Console.WriteLine("Some exception occured...{0}", ex2.Message);
            }
            
        }
        static double CalcInterest(double amount, int year, double rate)
        {
            double interest = amount * year * rate / 100;
            double totalAmount = amount + interest;
            return (totalAmount);
        }
    }
}
