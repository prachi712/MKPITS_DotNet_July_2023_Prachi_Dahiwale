using System;
namespace program
{
    interface bank
    {
        string deposit(int actno, int amount);
    }
    class saving : bank
    {
        int actno;
        int bal = 1000;
        int interest = 200;
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            bal = bal + amount + interest;
            return "actno:" + actno + "bal is:" + bal;

        }
    }
    class current : bank
    {
        int actno;
        int bal = 1000;
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "actno:" + actno + "bal is:" + bal;
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            bank b=null;
            Console.WriteLine("enter saving or current");
            string acttype = Console.ReadLine();
            switch(acttype)
            {
                case "saving":
                    b = new saving();
                    break;
                case "current":
                    b = new current();
                    break;

            }
            string res = b.deposit(1, 100);
            Console.WriteLine(res);
            Console.ReadKey();
                     
        }
    }
}
