using System;
namespace program
{
    class Animal
    {
        public string color = "white";
    }
    class dog : Animal
    {
        public string color = "red";
        public void displaycolor()
        {
            Console.WriteLine("dog color" + color);
            Console.WriteLine("animal colr:" + base.color);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            dog d = new dog();
            d.displaycolor();
            Console.ReadLine();
        }
    }
}