using System;
namespace tableprogram
{
    class program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            int flag = 0;
            while (counter < num)
            {
                if (num % counter == 0)
                {
                    flag = 1;
                    break;
                }
                counter++;

            }
            if (flag == 0)
            {
                Console.WriteLine("no is prime");
            }
            else
                Console.WriteLine("no is not prime");
        }
        
     }
}



