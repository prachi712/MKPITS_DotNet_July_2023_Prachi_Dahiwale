using System;
namespace equalprogream
{
    class equal
    {
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("num1 is equal to num2");
            else
                Console.WriteLine("num1 is not equal to num2");
            Console.ReadKey();
        }
    }
}