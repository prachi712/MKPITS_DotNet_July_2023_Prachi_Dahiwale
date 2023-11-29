using System;
using System.Collections.Generic;
namespace program
{
    class Program
    {
        static void Main(string[]args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("enter age:");
                age = Convert.ToInt32(Console.ReadLine());
                if(age<18)
                {
                    throw new Exception("age should be equal or greater than 18");
                }
            }
            catch(OverflowException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("enter a small numer please");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("enter 18 or greater than 18");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("finally block is executing");
                Console.WriteLine("Age=" + age);
            }
            Console.WriteLine("bye");
        }
    }
}