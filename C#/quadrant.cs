using System;
namespace QuadrantProgram
{
    class quadrant
    {
        public static void Main()
        {
            int x,y;
            Console.WriteLine("input the value for X coordinate");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the value for Y coordinate");
            y = Convert.ToInt32(Console.ReadLine());
            if(x>0 && y>0)
            {
                Console.WriteLine("lies on first quadrant");
                
            }
            else
            {
                Console.WriteLine("lies on second quadrant");
            }
            Console.ReadKey();
        }
    }
}