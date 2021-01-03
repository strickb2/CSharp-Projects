using System;

namespace AssignFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum= 1, i;
            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i=1; i <= num; i++)
            {
                sum *= i;
            }
            Console.WriteLine("The factorial of {0} is {1}", num, sum);
        }
    }
}
