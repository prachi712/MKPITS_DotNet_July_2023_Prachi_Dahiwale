using System;
namespace program
{
    public class Animal
    {
        public void eat()
        { Console.WriteLine("eating..."); }
    }
    public class Dog : Animal
    {
        public void bark()
        { Console.WriteLine("barking..."); }
    }
    public class BabyDog : Dog
    {
        public void weep()
        { Console.WriteLine("weeping...."); }
    }
    class prpgram
    {
        public static void Main(string[]args)
        {
            BabyDog b1 = new BabyDog();
            b1.eat();
            b1.bark();
            b1.weep();
        }
    }
}