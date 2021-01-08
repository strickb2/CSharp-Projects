using System;

namespace AssignVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            int count = 0;
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter Sentence: ");
                    sentence = Console.ReadLine();
                    if (string.IsNullOrEmpty(sentence) == true)
                    {
                        Console.Write("Sentence can't be empty! ");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                    {
                        count += 1;
                    }
                }
                Console.WriteLine($"The number of vowels in this sentence is {count}");
                Console.ReadKey();
            }
            catch (Exception ex1)
            {
                Console.WriteLine("An exception occurred : {0}", ex1.Message);
            }

        }
    }

}