using System;
using System.Security.Cryptography.X509Certificates;

namespace program
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread..");
        }
    }
     public class program
    {
        public static void Main()
        {
            Animal d = new Dog();
            d.eat();
        }
    }
}