using System;
namespace program
{
    class employee
    {
        protected int salary;
    }
    class programmer : employee
    {
        int bonus;
        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("salary" + salary);
            Console.WriteLine("bonus" + bonus);
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            programmer p1 = new programmer();
            p1.getdata(23000000, 50000);
            p1.displaydata();
        }
    }
}