using System;
namespace program
{
    class publictest
    {
        protected string name = "swayam";
        public void getdata()
        {
            Console.WriteLine("hello=" + name);
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            publictest publicTest=new publictest();
            publicTest.getdata();
        }
    }
}
