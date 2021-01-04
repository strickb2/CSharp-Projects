using System;

namespace AssignInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int LoanTime;
            double InterestRate, LoanAmount, SimpleInterest;
            try
            {
                Console.WriteLine("Enter Name: ");
                Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Loan Amount: ");
                LoanAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Loan Period (in years): ");
                LoanTime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Interest Rate: ");
                InterestRate = Convert.ToDouble(Console.ReadLine());
                SimpleInterest = LoanAmount * LoanTime * InterestRate;
                Console.WriteLine("{0}: Simple Interest Rate is {1}", Name, SimpleInterest);
            }
            catch(FormatException ex1)
            {
                Console.WriteLine("Invalid input format...{0}", ex1.Message);
            }
            
        }
    }
}
