using System;
namespace program
{
     class baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("hellow from base class");
        }
    }
    class  childclass:baseclass
    {
        public override void show()
        {
            Console.WriteLine("hellow from child class");
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            baseclass b = new childclass();
            b.show();
            Console.ReadKey();
        }
    }
}