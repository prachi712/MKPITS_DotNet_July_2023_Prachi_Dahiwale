using System;
namespace program
{
    public class Animal
    {
        public void eat()
        { Console.WriteLine("eating..."); }
    }
    public class Dog:Animal

    {
        public void bark()
        { Console.WriteLine("barking..."); }
    }
    class program
    {
        public static void Main(string[]args)
        {
            Dog d1 = new Dog();
            d1.eat();
            d1.bark();
        }
    }
}