using System;
namespace daysprogram
{
    class program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter month number");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                case 3:
                case 5:
                case 6:
                case 8:
                case 12:
                    Console.WriteLine("month have 31 days");
                    break;
                case 2:
                    Console.WriteLine("month have 28 day");
                    break;
                case 4:
                case 7:
                case 9:
                case 11:
                    Console.WriteLine("month have 30 days");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
                
            }
            Console.ReadKey();
        } 
    }
}