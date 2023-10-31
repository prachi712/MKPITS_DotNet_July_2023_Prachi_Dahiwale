using System;
namespace Program
{
    class employee
    {
        int emp_no;
        string emp_name;
        string designation;
        int salary;
        public void getdata(int eno,string ename,string des,int sal)
        {
            emp_no = eno;
            emp_name = ename;
            designation = des;
            salary = sal;
        }
        public void displaydata()
        {
            Console.WriteLine("emp no" + emp_no);
            Console.WriteLine("emp name" + emp_name);

            Console.WriteLine("designation" + designation);

            Console.WriteLine("salary" + salary);


        }
    }
    class Program
    {
         public static void Main(string[]args)
        {
            employee emps = new employee();
            emps.getdata(123, "prachi", "manager", 20000);
            emps.displaydata();
            Console.ReadKey();
        }
    }
}