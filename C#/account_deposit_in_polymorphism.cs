using System;
using System.Data;

namespace program
{
    public class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual string deposit(int actno,int amount)
        {
            return "deposit method of account class";
        }
        public string showbalance()
        {
            return "balance amount" + balance;
        }
    }
    class current : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "amount deposited successfully";
        }
    }
    public class program
    {
        public static void Main()
        {
            Account act=new current();
            string res = act.deposit(123, 2000);
            Console.WriteLine("account no is" + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);

        }

    }
}