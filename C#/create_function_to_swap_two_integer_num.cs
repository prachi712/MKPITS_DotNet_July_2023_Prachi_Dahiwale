using System;
namespace Program
{
    class program
    {
        static int display(int number1,int number2)
        {
            int res = 0;
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("now the first no.is " + number1 + ","  +"second number is:" + number2);
            return res;

        }
        static void Main(string[]args)
        {
            int number1, number2;
            Console.WriteLine("enter number1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            number2 = Convert.ToInt32(Console.ReadLine());
            int result = display(number1, number2);
            Console.ReadKey();
        }
    }
}