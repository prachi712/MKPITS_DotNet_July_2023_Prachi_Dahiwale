using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            for(int outercntr=1;outercntr<=3;outercntr++)
            {
                for(int innercntr=1;innercntr<=3;innercntr++)
                {
                    Console.Write(innercntr+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}