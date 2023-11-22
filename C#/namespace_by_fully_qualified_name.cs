using System;
namespace first
{
    public class Hello
    {
        public void sayHello() { Console.WriteLine("hello fiest namespace"); }
    }
}
namespace second
{
    public class Hello
    {
        public void sayHello() { Console.WriteLine("hello second namespace"); }
    }
}
public class Testnamespace
{
    static void Main()
    {
        first.Hello h1 = new first.Hello();
        second.Hello h2 = new second.Hello();
        h1.sayHello();
        h2.sayHello();
    }
}

