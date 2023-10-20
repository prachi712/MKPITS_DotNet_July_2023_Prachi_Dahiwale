using System;
namespace Circleprogram
{
    class Circle
    {
        public static void Main()
        {
            int radius;
            float area, circ; ;
             
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
            Console.WriteLine("area=" + area);
            Console.WriteLine("circ=" + circ);
            Console.ReadKey();
        }
    }
}