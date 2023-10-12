using System;
namespace Shortprogram
{
    class Shortushort
    {
        public static void Main()
        {
            short b = 29180;
            Console.WriteLine("value " + b);
            Console.WriteLine("enter short");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("value" + b);

            ushort b1 = 23890;
            Console.WriteLine("value " + b1);
            Console.WriteLine("enter sbyte");
            b1 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("value" + b1);
            Console.ReadLine();

        }
    }
}