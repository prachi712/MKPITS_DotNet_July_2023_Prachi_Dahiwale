using System;
namespace program
{
    class publictest
    {
        protected string name = "swayam";
        protected void msg(string msg)
        {
            Console.WriteLine("hello=" + msg);
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            publictest publicTest=new publictest();
            Console.WriteLine("name");
        }
    }
}