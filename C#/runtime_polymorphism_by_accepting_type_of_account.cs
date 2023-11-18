using System;
using System.Security.AccessControl;

namespace program
{
    public class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual string deposit(int actno,int amount)
        {
            return "deposit method account class";
        }
        public string showbalance()
        {
            return "balance amount" + balance;
        }
    }
    class current:Account

    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return " amount deposited successfully";
        }
    }
    class saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance + amount + interest;
            return "amount deposited successfully with interest";
        }
             
    }
    public class  program
    {
        public static void Main()
        {
            Console.WriteLine("enter account number");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type");
            string accountype = Console.ReadLine();
            Account act = null;
            if (accountype == "saving")
            {
                act = new saving();
            }
            else if (accountype == "current")
            {
                act = new current();
            }
            string res = act.deposit(actno, amount);
                Console.WriteLine("account no is:" + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);

        }
    }
}