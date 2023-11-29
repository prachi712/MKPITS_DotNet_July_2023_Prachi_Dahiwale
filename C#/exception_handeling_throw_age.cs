using System;
using System.Collections.Generic;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("enter age");
                age = Convert.ToInt32(Console.ReadLine());
                if(age<=18)
                {
                    throw new Exception("age should be greater or equal to 18");
                }
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("enter age or greater than 18");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("finally block is executed");
                Console.WriteLine("Age:" + age);
            }
            Console.WriteLine("bye");
        }
    }
}