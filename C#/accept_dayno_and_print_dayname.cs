using System;
namespace Daynumber
{
    class day
    {
        public static void Main(string[]args)
        {
            int dayno;
            Console.WriteLine("enter day number");
            dayno = Convert.ToInt32(Console.ReadLine());
            switch(dayno)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                default:
                    Console.WriteLine("some other days");
                    break;
            }
            Console.ReadKey();
        }
    }
}