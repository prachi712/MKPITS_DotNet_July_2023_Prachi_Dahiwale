using System;
namespace Vowelcharprogram
{
    class number
    {
        public static void Main(string[] args)
        {
            char op;
            Console.WriteLine("enter character");
            op= Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("character is vowel");
                    break;
                default:
                    Console.WriteLine("character is not vowel");
                    break;

            }
            Console.ReadKey();

        }
    }
}