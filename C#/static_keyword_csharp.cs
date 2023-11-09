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
}
class Program
{
static void Main(string[] args)
{
Book.bookid = 12;
Console.WriteLine("book id " + Book.bookid);
}
}
}