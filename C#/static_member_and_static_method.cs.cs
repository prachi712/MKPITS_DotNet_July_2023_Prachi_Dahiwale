using System;
namespace Program
{
    class book
    {
        static string title;
        static book()
        {
            Console.WriteLine("static constructor called");
            title = "mkpits";
        }
          public static void display()
        {
            Console.WriteLine("title:" + title);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            book.display();
            Console.ReadKey(); 
        }
    }
}