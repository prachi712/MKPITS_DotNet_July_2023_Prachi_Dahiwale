using System;
namespace Leapyprogram
{
    class leap
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter year");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%4==0)
            {
                Console.WriteLine("is a leap year");
            }
            else
            {
                Console.WriteLine("is not leap year");
            }
            Console.ReadKey();

        }
    }
}