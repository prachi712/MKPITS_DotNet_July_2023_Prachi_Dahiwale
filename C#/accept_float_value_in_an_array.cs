using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            float[] fl = new float[3];
            int sum = 0;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter float value");
                fl[i] = Convert.ToSingle(Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("fl[{0}]={1}", i, fl[i]);
            }
            Console.ReadKey();``
        }
    }
}