using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("prachi");
            sb.Append("Dahiwale");
            Console.WriteLine("sb=" + sb.ToString());
            object obj = sb;
            Console.WriteLine("obj=" + obj.ToString());
            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(InvalidCastException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("bye");
        }
    }
}