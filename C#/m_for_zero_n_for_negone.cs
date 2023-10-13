using System;
namespace Mprogram
{
    class mvalue
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter test data");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("0");
            }
            else
                Console.WriteLine("-1");
        }

    }
}
