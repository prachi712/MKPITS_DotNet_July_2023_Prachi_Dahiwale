using System;
namespace program
{
    class company
    {
        public string name = "fendahl";
        public company()
        {
            Console.WriteLine("base class constructor");
            Console.WriteLine("company name:" + name);
        }
    }
    class frenchise : company
    {
        public string name = "hexaware";
        public frenchise()
        {
            Console.WriteLine("derived class ");
            Console.WriteLine("f name" + name);
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            frenchise f = new frenchise();
            Console.ReadLine();
        }
    }

}