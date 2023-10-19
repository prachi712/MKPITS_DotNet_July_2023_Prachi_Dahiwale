using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for(int counter=num;counter>0;counter--)
            {
                fact = fact * counter;
            }
            Console.WriteLine("fact=" + fact);
            Console.ReadKey();

        }
    }
}