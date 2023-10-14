using System;
namespace Quadraticequation
{
    class equation
    {
        public static void Main()
        {
            int a,b,c;
            float res;
            Console.WriteLine("input the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the value of c");
            c = Convert.ToInt32(Console.ReadLine());
            res = b * b - 2 * a * c;
            if(a!=res)
            {
                Console.WriteLine("root is imaginary");
            }
            else
            {
                Console.WriteLine("No Solution");
            }
            Console.ReadKey();


        }
    }
}