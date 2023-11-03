using System;
namespace program
{
    class book
    {
        int bookid;
        string title;
        string author;
        int price;
        public book()
        {
            bookid = 1;
            title = "mkpits";
            author = "prachii";
            price = 65000;
        }
        public void display()
        {
            Console.WriteLine("book id=" + bookid);
            Console.WriteLine("book title=" + title);
            Console.WriteLine("book author" + author);
            Console.WriteLine("book prise=" + price);
        }

    }
    class Program
    {
        static void Main(string[]args)
        {
            book b = new book();
            b.display();
            Console.ReadLine();
        }

    }
}