using System;
namespace threegreatprogram
{
    class greatno
    {
        public static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num3 > num1)
                Console.WriteLine("num1 is greater");

            else if (num2 > num3)
                Console.WriteLine("num2 is greater");

            else 
                Console.WriteLine("num3 is greater");

            Console.ReadKey();

        }
    }
}


