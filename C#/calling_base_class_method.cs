using System;
namespace program
{
    class company
    {
        public string name = "mkcl";
        public void display()
        {
            Console.WriteLine("company name:" + name);
        }
    }
    class franchise : company
    {
        public string name = "mkpits";
        public void display()
        {
            base.display();
            Console.WriteLine("franchiose name" + name);
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            franchise f = new franchise();
            f.display();
            Console.ReadLine();
        }
    }
}