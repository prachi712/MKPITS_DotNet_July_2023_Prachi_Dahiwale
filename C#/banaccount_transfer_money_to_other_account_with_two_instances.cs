using System;
namespace Program
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int Balance { get; set; }
        public void display()
        {
            Console.WriteLine("account details of customer");
            Console.WriteLine("------------------------");
            Console.WriteLine("Account number:" + AccountNumber);
            Console.Write("account holder name:" + AccountHolderName);
            Console.WriteLine("Balance" + Balance);
        }
        public void transfer(BankAccount ba)
        {
            Balance = Balance + ba.Balance;
            ba.Balance = 0;
        }
        public void showbalance()
        {
            Console.WriteLine("current bal for account no {0} is {1}", AccountNumber, Balance);
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1;
            b1.AccountHolderName = "prachi";
            b1.Balance = 100;
            b1.display();


            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 2;
            b2.AccountHolderName = "swayam";
            b2.Balance = 500;
            b2.display();
            b1.transfer(b2);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("balance after transaction");
            b1.showbalance();
            b2.showbalance();
            Console.ReadKey();


        }
    }
}