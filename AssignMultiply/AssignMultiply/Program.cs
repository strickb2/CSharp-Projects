using System;

namespace AssignMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, sum;
            Console.Write("Enter the First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            sum = num1 * num2 * num3;
            Console.WriteLine("The sum is: {0} ", sum);
            Console.Read();
        }
    }
}
