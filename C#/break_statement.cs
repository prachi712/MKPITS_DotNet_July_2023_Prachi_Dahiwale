using System;
namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 1;
            while(num<=10)
            {
                Console.WriteLine(num);
                if(num==5)
                {
                    break;
                }
                num++;
            }
        }
    }
}