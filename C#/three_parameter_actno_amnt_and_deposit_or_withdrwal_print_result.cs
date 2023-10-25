using System;
namespace pprogram
{
    class program
    {
        static int calculate(int actno,int amount)
        {
            int result=0;
            int bal =1000;
            
            int diposit = amount + bal;
            int withdrawl = amount - bal;
            Console.WriteLine("deposit" + diposit);
            Console.WriteLine("withdrwal" + withdrawl);
            return result;
        }
        static void Main(string[]args)
        {
            int actnum, amt;
            Console.WriteLine("enter acount no");
            actnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount");
            amt = Convert.ToInt32(Console.ReadLine());
            
            int result = calculate(actnum, amt);
            
            Console.ReadKey();
        }
    }
}