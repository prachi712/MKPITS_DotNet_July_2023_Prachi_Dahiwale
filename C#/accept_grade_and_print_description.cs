using System;
namespace gradeprogram
{
    class program
    {
        public static void Main(string[]args)
        {
            char grade;
            string description;
            Console.WriteLine("enter a grade");
            grade = Convert.ToChar(Console.ReadLine());
            switch(grade)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("very good");
                    break;
                case 'G':
                    Console.WriteLine("good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;



            }
            Console.ReadKey();
        }
    }
}