using System;
namespace monthprogram
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            
            Console.WriteLine("enter month number");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("january");
                    break;
                case 2:
                    Console.WriteLine("february");
                    break;
                case 3:
                    Console.WriteLine("march");
                    break;

                case 4:
                    Console.WriteLine("april");
                    break;

                case 5:
                    Console.WriteLine("may");
                    break;

                case '6':
                    Console.WriteLine("june");
                    break;

                case 7:
                    Console.WriteLine("july");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;


            }
            Console.ReadKey();
        }
    }
}