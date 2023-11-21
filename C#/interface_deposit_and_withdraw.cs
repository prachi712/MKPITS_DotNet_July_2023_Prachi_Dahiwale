using System;
namespace program
{
    interface bank
    {
        string deposit(int actno, int amount);
        string withdraw(int actno, int amount);
    }
    class Account
    {
        public int actno;
        public int bal = 100;
        public string showbalance()
        {
            return "bal is:" + bal ;
        }
    }
    class saving : Account, bank
    {
        public string deposit(int actno,int amount)
        {
            this.actno=actno;
            bal = bal + amount;
            return "deposited successfully,bal is:" + bal;
        }
        public string withdraw(int actno,int amount)
        {
            this.actno = actno;
            bal = bal - amount;
            return "withdraw successfully,bal is:" + bal;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            saving b;
            b = new saving();
            string str = b.deposit(1, 200);
            Console.WriteLine(str);
            str = b.withdraw(1, 100);
            Console.WriteLine(str);
            Console.WriteLine(b.showbalance());
        }
    }
}