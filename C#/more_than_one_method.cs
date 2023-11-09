using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
class Book
{
public static int bookid;
public static void display()
{
Console.WriteLine("hello from static display method");
}
}
class Program
{
static void Main(string[] args)
{
Book.bookid = 12;
Program p = new Program();
p.Main();
Console.WriteLine("book id " + Book.bookid);

}
void Main()
{
Console.WriteLine("hello from another main method");
}
}
}