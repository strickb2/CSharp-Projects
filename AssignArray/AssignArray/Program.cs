using System;

namespace AssignArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new int[10];
            int i, temp;
            for (i = 0; i < elements.Length - 1; i++)
            {
                Console.WriteLine("Enter number: ");
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < elements.Length - 1; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i] < elements[j])
                    {
                        temp = elements[i];
                        elements[i] = elements[j];
                        elements[j] = temp;
                    }
                }
            }
            foreach(int element in elements)
                {
                    Console.WriteLine(" {0}", element);
                }                              
        }
    }
}
