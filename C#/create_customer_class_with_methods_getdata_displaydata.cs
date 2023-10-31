using System;
namespace Program
{
    class customer
    {
        int customer_code;
        string customer_name;
        public void getdata(int cc,string cn)
        {
            customer_code = cc;
            customer_name = cn;
        }
        public void displaydata()
        {
            Console.WriteLine("customer code" + customer_code);
            Console.WriteLine("customer name" + customer_name);
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            customer cust = new customer();
            cust.getdata(123, "swayam");
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
    