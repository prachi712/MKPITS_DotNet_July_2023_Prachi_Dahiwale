using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
class Book
{
int bookid;
string title;
string author;
int price;
//creating a constructor with no parameters
public Book()
{
Console.WriteLine("constructor with no parameters called");
bookid = 123;
title = "vb.net";
author = "roshan kumar";
price = 2333;
}
//creating a parameterized constructor with 4 parameters
public Book(int bookid,string title,string author,int price)
{
Console.WriteLine("constructor with parameters called");
this.bookid = bookid;
this.title = title;
this.author = author;
this.price = price;

}
public void display()
{
Console.WriteLine("book id : " + bookid);
Console.WriteLine("title : " + title);
Console.WriteLine("author : " + author);
Console.WriteLine("price : " + price);

}
}

class Program
{
static void Main(string[] args)
{
Book b1 = new Book(); //this will call constructor with no parameter automatically
b1.display();

Book b2 = new Book(22, "oracle", "ashis", 400); //this will call parameterized constructor
b2.display();
}
}
}