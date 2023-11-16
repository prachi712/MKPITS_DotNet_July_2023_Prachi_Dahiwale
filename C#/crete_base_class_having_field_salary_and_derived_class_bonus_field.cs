using System;
namespace program
{
    public class Employee
    {
        public float salary = 6000000;
    }
    public class programmer : Employee
    {
        public float bonus = 10000;
    }
    class testinheritance
    {
        public static void Main(string[] args)
        {
            programmer p1 = new programmer();
            Console.WriteLine("salary" + p1.salary);
            Console.WriteLine("bonus" + p1.bonus);
        }
    }
}