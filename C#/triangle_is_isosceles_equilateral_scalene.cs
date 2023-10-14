using System;
namespace Triangleprogram
{
    class triangle
    {
        public static void Main()
        {
            int a,b,c;
            Console.WriteLine("enter the value of angle a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of angle b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of angle c");
            c = Convert.ToInt32(Console.ReadLine());

            if (a==b && a==c)
            {
                Console.WriteLine("triangle is equilateral");
            }
            else if(a==b || b==c || a==c)
            {
                Console.WriteLine("Trisngle is Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is scales");
            }
        }
    }
}