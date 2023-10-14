using System;
namespace temperature
{
    class temp
    {
        public static void Main()
        {
            int temp;
            Console.WriteLine("Enter temprature");
            temp = Convert.ToInt32(Console.ReadLine());
            if(temp<0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp>0&&temp<=10)
            {
                Console.WriteLine("very cold weather");

            }
            else if(temp>10&&temp<=20)
            {
                Console.WriteLine("normal temp");
            }
            else if(temp>20&&temp<=30)
            {
                Console.WriteLine("hot temp");

            }
            else if(temp>30&&temp<=40)
            {
                Console.WriteLine("its very hot");
            }
            else
            {
                Console.WriteLine("very hot");
            }
            Console.ReadKey();
        }
    }
}