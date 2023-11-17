using System;
namespace program
{
    public class Anamal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class Dog:Anamal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread");
        }
    }
    public class program
    {
        static void Main(string[]args)
        {
            Anamal a = new Dog();
            a.eat();
        }
    }
}