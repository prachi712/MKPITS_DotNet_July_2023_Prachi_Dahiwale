using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
class Class1
{
struct student
{
public int id;
public String name;
public String course;
}
public static void Main()
{
student s1;
s1.id = 20;
s1.name = "mahir";

s1.course = "dotnet";

Console.WriteLine("rno " + s1.rno);
Console.WriteLine("name " + s1.name);
Console.WriteLine("course " + s1.course);

}
}
}