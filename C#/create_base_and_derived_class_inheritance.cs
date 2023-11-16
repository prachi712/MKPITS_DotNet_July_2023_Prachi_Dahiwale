using System;
namespace Program
{
    class person
{
    public string name;
}
class student:person
{
    public int rno;
}
class program
   {
    public static void Main(string[]args)
    {
        student s = new student();
        s.rno = 111;
        s.name = "prachi";
        Console.WriteLine("rno=" + s.rno);
        Console.WriteLine("name=" + s.name);
    }
   }
}