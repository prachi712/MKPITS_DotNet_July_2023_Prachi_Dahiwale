using System;
namespace program
{
    class publictest
    {
        internal string name = "swayam";
        internal void msg(string msg)
        {
            Console.WriteLine("hello=" + msg);
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            publictest publicTest=new publictest();
            Console.WriteLine("hello"+publicTest.name);
            publicTest.msg("mkpits");
        }
    }
}