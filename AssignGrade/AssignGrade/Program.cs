using System;

namespace AssignGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade;
            bool studentPassed;
            Console.Write("Enter Grade: ");
            grade = Convert.ToInt32(Console.ReadLine());
            studentPassed = grade >= 55 ? true : false; 
            Console.WriteLine("Student has passed: {0}", studentPassed);
            Console.Read();
        }
    }
}
