using System;
namespace program
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;
        public Employee()
        {
            empno = 123;
            empname = "prachi";
            designation = "manager";
            salary = 700000;

        }
        public void display()
        {
            Console.WriteLine("Employee no==" + empno);
            Console.WriteLine("Employee name==" + empname);
            Console.WriteLine("Employee designation==" + designation);
            Console.WriteLine("Employee salary==" + salary);
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Employee e=new Employee();
            e.display();
            Console.ReadLine();
        }
    }
}