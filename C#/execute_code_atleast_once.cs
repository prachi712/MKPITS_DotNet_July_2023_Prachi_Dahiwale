using System;
namespace program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num = 10;
            do
            {
                Console.WriteLine("num={0}", num);
                num++;
            }
            while (num <= 5);
            Console.WriteLine("bye");
            Console.ReadKey();
        }
     
    }
}