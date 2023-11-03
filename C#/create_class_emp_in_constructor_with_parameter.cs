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
            Console.WriteLine("constructor with no parameter");
            empno = 123;
            empname = "prachii";
            designation = "manager";
            salary = 8000000;
        }
        public Employee(int empno,string empname,string designation,int salary)
        {
            Console.WriteLine("constructor with parameter");
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("empno=" + empno);
            Console.WriteLine("empname=" + empname);
            Console.WriteLine("designation=" + designation);
            Console.WriteLine("salary=" + salary);

        }
        

    }
    class Program
    {
        static void Main(string[]args)
        {
            Employee e = new Employee();
            e.display();
            Employee e1 = new Employee(123, "prachii", "manager", 800000);
            e1.display();
        }
    }
}
