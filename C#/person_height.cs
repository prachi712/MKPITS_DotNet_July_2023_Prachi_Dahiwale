using System;
namespace Heightprogram
{
    class height
    {
        public static void Main()
        {
            int height;
            Console.WriteLine("enter tst data");
            height = Convert.ToInt32(Console.ReadLine());
            if(height>=150)
            {
                Console.WriteLine("the person is tall");
            }
            else
            {
                Console.WriteLine("person is Dwarf");
            }
            Console.ReadKey();
        }
    }
}