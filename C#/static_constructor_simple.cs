using System;
namespace staticconstructor
{
    public class employee
    {
        static employee()``
        declaration{Console.WriteLine("The static constructor ");


    }
    public static void salary()
    {
        Console.WriteLine();
        Console.WriteLine("salary method");
    }
       
      
    class Details
    {
        static void Main(string[]args)
        {
            Console.WriteLine("static constructor");
            Console.WriteLine();
            employee.salary();
            Console.ReadLine();
        }
    }
}