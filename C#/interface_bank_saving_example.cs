using System;
using System.Runtime.CompilerServices;

namespace program
{
    interface bank
    {
        string deposit(int actno, int amt);
    }
    class saving : bank
    {
        int actno;
        int bal = 1000;
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited successfully,bal is" + bal;
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            bank b;
            b = new saving();
            string str = b.deposit(1, 200);
            Console.WriteLine(str);
        }
    }
}