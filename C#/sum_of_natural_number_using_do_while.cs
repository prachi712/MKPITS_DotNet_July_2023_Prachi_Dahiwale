using System;
namespace program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num = 1;
            int sum = 0;
                
            
            do
            {
                sum = sum + num;
                Console.WriteLine("numbers are:"  +num);
                num++;
            }
            while (num <= 10);
            
            Console.WriteLine("sum of the number.:" +sum);

        }
    }
}