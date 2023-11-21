using System;
namespace program
{
    interface readable
    {
        string readdata();
        string writedata(string data);
    }
    interface writeable
    {
        string readdata();
        string writedata(string data);
    }
    class filehandler : readable, writeable
    {
        public string readdata()
        {
            return "readdata";
        }

        public string writedata(string data)
        {
            return "writedata";

        }
    } 
   class program
     {
        public static void Main(string[]args)
        {
            readable r = new filehandler();
            string res = r.readdata();
            Console.WriteLine(res);
            string res2 = r.writedata("hi from writedata");
            Console.WriteLine(res2);

            writeable w = new filehandler();
            string res1 = w.readdata();
            Console.WriteLine(res1);
            string res3 = r.writedata("hi from writedata");
            Console.WriteLine(res3);
            Console.ReadKey();

        }

    }
}