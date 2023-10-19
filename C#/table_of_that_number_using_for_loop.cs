using System;
namespace program
{
    class program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            for (counter = 1; counter <=10; counter++)
            {
                result = num * counter;
                Console.WriteLine("{0}*{1}={2}", num, counter, result);
                
            }
            
            Console.ReadKey();
        }
    }
}
