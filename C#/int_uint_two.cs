using System;
namespace intuintprogram
{
    class datatype
    {
        public static void Main()
        {
            int b = 25890;
            Console.WriteLine("valur" + b);
            Console.WriteLine("enter");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value " + b);
            uint b1 = 23456781;
            Console.WriteLine("value" + b1);
            Console.WriteLine("enter");
            b1 = Convert.ToUInt32(Console.ReadLine());
                
            Console.WriteLine("value " + b1);
            Console.ReadLine();
        }
    }
}