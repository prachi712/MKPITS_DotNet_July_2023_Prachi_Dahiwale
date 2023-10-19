using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            int counter = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            while(true)
            {
                if (sum <= num)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine("odd no:{0}", counter);
                        sum = sum + 1;
                    }
                }
                else
                {
                    break;
                }
                    counter++;
                
            }
        }
    }
}