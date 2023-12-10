using System;
using System.Security.Cryptography.X509Certificates;

namespace program
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;
        public Book()
        {
            Console.WriteLine("constructor with no parameter");
            bookid = 123;
            title = "mkpits";
            author = "prachiii";
            price = 2222;
        }
        public Book(int bookid,string title,string author,int price)
        {
            Console.WriteLine("constructor with no parameter");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("bookid:" + bookid);
            Console.WriteLine("title:" + title);
            Console.WriteLine("author" + author);
            Console.WriteLine("price:" + price);
        }
    }
    class Program
   
        static void Main(string[]args)
        {
            Book b = new Book();
            b.display();
            Book b1 = new Book(22, "mkpits", "prachii", 70000);
            b.display();
        }
    }
}