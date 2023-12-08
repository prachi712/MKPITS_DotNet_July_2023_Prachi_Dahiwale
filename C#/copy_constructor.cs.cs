using System;
namespace program
{
    class book
    {
        int bookid;
        string title;
        public book()
        {
            bookid = 123; 
            title = "mkpits";
        }
        public book(book b2)
        {
            bookid = b2.bookid;
            title = b2.title;
        }
        public void display()
        {
            Console.WriteLine("bookid:" + bookid);
            Console.WriteLine("title:" + title);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            book book1 = new book();
            book book2= new book(book1);
            Console.WriteLine("book 1 details are");
            book1.display();
            Console.WriteLine("book 2 details are");
            book2.display();
            Console.ReadKey();
        }
    }
}