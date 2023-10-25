using System;
namespace programone
{
    class program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while(true)
            {
                Console.WriteLine(i);
                i++;
                if (i < 10)
                    continue;
                else
                    break;
            }
            Console.ReadKey();
        }
    }
}