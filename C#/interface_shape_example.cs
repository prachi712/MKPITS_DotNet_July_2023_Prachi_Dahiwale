using System;
namespace Program
{
    interface shape
    {
        void draw();
    }
    class rectangle : shape
    {
        public void draw()
        {
            Console.WriteLine("draw method of rectangle");
        }
    }
    class circle:shape
    {
        public void draw()
        {
            Console.WriteLine("draw method of circle class");
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            shape s = new rectangle();
            s.draw();
            s = new circle();
            s.draw();
        }
    }
}