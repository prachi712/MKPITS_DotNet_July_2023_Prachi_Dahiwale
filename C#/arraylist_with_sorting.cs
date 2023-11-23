using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(21);
            ar.Add(22);
            ar.Add(23);
            Console.WriteLine("arraylict collection wthout sorting");
            foreach(int obj in ar)
            {
                Console.WriteLine("students rollno:" + obj);
            }
            ar.Sort();
            Console.WriteLine("arraylist collections with sorting");
            foreach(int obj in ar)
            {
                Console.WriteLine("students rollno:" + obj);
            }

        }
    }
}