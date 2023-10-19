using System;
namespace program
{
    class program
    {
        public static void Main(string[] args)
        {
            int num;
            int rem = 0;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int counter;

            for (counter = 2; counter < num; counter++)

            {
                rem = num % counter;
                if (rem == 0)
                {
                    Console.WriteLine("it is not prime  number");
                    break;
                    counter = 1;
                }

            }
            if (num == counter)
            {
                Console.WriteLine("it is a prime  number");
            }
            Console.ReadKey();

        }

    }
}