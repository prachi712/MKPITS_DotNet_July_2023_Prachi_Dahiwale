using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int counter = 1;
            int num=1;
            int res= 0;
            do
            {
                res = counter * counter * counter;
                Console.WriteLine("cube of number are" +num);
                Console.WriteLine("no is:{0} and cube of {1} is:{2}", counter, counter, res);
                counter++;

            }
            while (counter <= num);
        }
    }
}