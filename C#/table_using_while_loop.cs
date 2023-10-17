using System;
namespace tableprogram
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            Console.WriteLine("enter any number");
            num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int counter = 1;
            while(counter<=10)
            {
                result = num * counter;
                Console.WriteLine("{0}*{1}={2}", num, counter, result);
                counter++;

            }
            Console.ReadLine();
        }
    }
}