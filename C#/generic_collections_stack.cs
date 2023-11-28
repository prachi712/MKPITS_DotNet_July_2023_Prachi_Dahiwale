using System;
using System.Collections.Generic;
namespace program
{
    class Program
    {
        static void Main(string[]args)
        {
            Stack<int> stc = new Stack<int>();
            stc.Push(1);
            stc.Push(2);
            stc.Push(5);
            stc.Push(3);
            stc.Push(4);
            Console.WriteLine(stc.Pop);
            Console.WriteLine(stc.Peek());
            Console.WriteLine(stc.Peek());
            Console.WriteLine();
            foreach(int item in stc)
            {
                Console.WriteLine(item);
            }
        }
    }
}