using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            int res = 0;
            for(int counter=1;counter<=5;counter++)
            {
                res = counter * counter * counter;
                Console.WriteLine("cube of :" + counter);
                Console.WriteLine("no.is:{0}cube{1} is :{2}", counter, counter, res);
            }
        }
    }
}