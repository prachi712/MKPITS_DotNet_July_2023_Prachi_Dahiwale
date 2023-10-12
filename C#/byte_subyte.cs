using System;
namespace Byteprogram
{
    class bytes
    {
        public static void Main()
        {
            byte b = 25;
            Console.WriteLine("byte value " + b);
            Console.WriteLine("enter value");
            b = Convert.ToByte(Console.ReadLine());
            sbyte b1 = -23;
            Console.WriteLine("sbyte value" + b1);
            Console.WriteLine("enter value");
            b1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte=" + b1);
            Console.ReadLine();
        }
    }
}
