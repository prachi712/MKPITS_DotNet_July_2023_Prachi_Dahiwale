using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            char[]ch= new char[3];
            int sum = 0;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter character");
                ch[i]= Convert.ToChar(Console.ReadLine());
            }
            for(int i = 0; i < 3; i++)
            {
                Console.Write(" {0}", ch[i]);
            }
            Console.ReadKey();
        }
    }
}