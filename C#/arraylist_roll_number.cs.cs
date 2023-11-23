using System;
using System.Collections;
namespace program
{
    class Program
    {
        static void Main(string[]args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(12);
            ar.Add(23);
            ar.Add(85);
            foreach(object obj in ar)
            {
                Console.WriteLine("rollnumber:" + obj);
            }
            Console.WriteLine("Count:{3}" + ar.Count);
            Console.WriteLine("capacity:{0}" + ar.Capacity);
        }
    }
}