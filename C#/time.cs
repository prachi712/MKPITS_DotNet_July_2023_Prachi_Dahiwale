using System;
namespace threegreatprogram
{
    class day
    {
        public static void Main()
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            Console.ReadKey();
        }
    }
}
