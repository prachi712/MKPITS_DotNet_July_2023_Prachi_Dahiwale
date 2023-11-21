using System;
namespace program
{
    interface bank
    {
        string deposit(int actno, int amount);
        string withdraw(int actno, int amount);
        string showbalance();
    }
    class Account
    {
        public int actno;
        public int bal = 1000;
        public int interest = 500;
    }
    class saving : Account,bank
    {
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            bal = bal + amount + interest;
            return "actno:"+actno +"bal is:" + bal;
        }
        public string withdraw(int actno,int amount)
        {
            this.actno = actno;
            bal = bal - amount;
            return "actno:" + actno + "bal is:" + bal;
        }
        public string showbalance()
        {
            return "actno:" + actno + "bal is:" + bal;

        }
    }
    class current : Account, bank
    {
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "actno:" + actno + "bal is" + bal;
        }
        public string withdraw(int actno,int amount)
        {
            this.actno = actno;
            bal = bal - amount;
            return "actno:" + actno + "bal is" + bal;
        
        }
        public string showbalance()
        {
            return "actno:" + actno + "bal is" + bal;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            bank b = null;
            Console.WriteLine("enter saving or current");
            string acttype = Console.ReadLine();
            string res = null;
            switch(acttype)
            {
                case "saving":
                    b=new saving();
                    break;
            }
            Console.WriteLine("enter deposit or withdrawl");
            string tt = Console.ReadLine();
            if (tt == "deposit")
                res = b.deposit(1, 700);
            else if (tt == "withdraw")
                res = b.withdraw(1, 500);

            Console.WriteLine(res);
            Console.WriteLine(b.showbalance());
            Console.ReadKey();

        }
    }
}