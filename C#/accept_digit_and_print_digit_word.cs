using System;
namespace Worddigitprogream
{
    class program
    {
        public static void Main(string[] args)
        {
            int digit;
            Console.WriteLine("enter any digit");
            digit = Convert.ToInt32(Console.ReadLine());
            switch(digit)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;



            }
            Console.ReadKey();

        }
    }
}