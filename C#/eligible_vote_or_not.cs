using System;
namespace Voteprogram
{
    class vote
    {
        public static void Main()
        {
            int age;
            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
            if(age>= 18)
            {
                Console.WriteLine("prachi is eligible for vote");
            }
            else
            {
                Console.WriteLine("is not eligible for vote");
            }
            Console.ReadKey();


        }
    }
}