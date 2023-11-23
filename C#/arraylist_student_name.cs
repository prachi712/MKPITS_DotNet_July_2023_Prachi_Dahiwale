using System;
using System.Collections;
namespace program
{
    class Program
    {
        public static void Main(string[]args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("prachi");
            ar.Add("swayam");
            ar.Add("sayyam");
            foreach(object obj in ar)
            {
                Console.WriteLine("student name:" + obj);
            }
        }
    }
}