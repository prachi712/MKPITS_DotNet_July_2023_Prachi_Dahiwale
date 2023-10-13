using System;
namespace greatestprogram
{
    class grestestno
    {
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine("num1 is greater");
            else
                Console.WriteLine("num2 is greater");
            Console.ReadKey();



        }
    }
}