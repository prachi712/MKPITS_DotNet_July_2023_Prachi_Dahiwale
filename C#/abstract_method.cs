using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
abstract class account
    {
        public int acctno;
        public int bal = 1000;
        public abstract void deposit(int amt);
       
        public void showbalance()
        {
            Console.WriteLine("bal amount for account no {0} is {1} " , acctno,bal);
        }
    }
    class current : account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;

        }
    }
    class saving : account
    {
        public override void deposit(int amt)
        {
            int interest = 200;
            bal = bal + amt+ interest;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("enter account no");
            int acctno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type saving or current");
            string acttype = Console.ReadLine();
            account act = null;
            if(acttype=="saving")
            {
                act = new saving();
            }
            else if(acttype=="current")
            {
                act = new current();
            }
            act.acctno = acctno;
            act.deposit(amt);    using System;  
    public abstract class Shape  
    {  
        public abstract void draw();  
    }  
    public class Rectangle : Shape  
    {  
        public override void draw()  
        {  
            Console.WriteLine("drawing rectangle...");  
        }  
    }  
    public class Circle : Shape  
    {  
        public override void draw()  
        {  
            Console.WriteLine("drawing circle...");  
        }  
    }  
    public class TestAbstract  
    {  
        public static void Main()  
        {  
            Shape s;  
            s = new Rectangle();  
            s.draw();  
            s = new Circle();  
            s.draw();  
        }  
    }  

            act.showbalance();
        }
    }
}
