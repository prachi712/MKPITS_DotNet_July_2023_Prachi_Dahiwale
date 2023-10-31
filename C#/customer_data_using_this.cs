using System;
namespace Program
{
    class employee
    {
        int customer_code;
        string customer_name;
        
        public void getdata(int customer_code,string customer_name)
        {
            this.customer_code = customer_code;
            this.customer_name = customer_name;
        }
        public void displaydata()
        {
            Console.WriteLine("customer code" + customer_code);
            Console.WriteLine("emp name" + customer_name);

            


        }
    }
    class Program
    {
         public static void Main(string[]args)
        {
            employee cust = new employee();
            Console.WriteLine("enter customer code and customer name");
            int cc = Convert.ToInt32(Console.ReadLine());
            string cn = Console.ReadLine();
            cust.getdata(cc,cn);
            cust.displaydata();
            
            Console.ReadKey();
        }
    }
}