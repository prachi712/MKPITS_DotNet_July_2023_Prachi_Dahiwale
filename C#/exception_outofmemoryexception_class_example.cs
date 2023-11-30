using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class Program
    {
        static void Main(string[]args)
        {
            string name = "prachi";
            string subject = "mathematics";
            Console.WriteLine("length of name:" + name.Length);
            StringBuilder sb = new StringBuilder(name.Length, name.Length);
            try
            {
                sb.Append("subject name");
            }
            catch(OutOfMemoryException ee)
            {
                Console.WriteLine(ee.ToString());
            }
        }
    }
}