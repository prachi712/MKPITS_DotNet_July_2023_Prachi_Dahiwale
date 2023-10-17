using System;
using System.Reflection.Metadata;

namespace factprogram
{
    class program
    {
        public static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 10)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("{0} is even", counter);
                    counter = counter + 1; ;
                }
                Console.ReadKey();
            }
        }
    }
}
