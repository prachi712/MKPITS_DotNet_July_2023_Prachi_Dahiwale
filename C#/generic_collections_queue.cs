using System;
using System.Collections.Generic;
namespace program
{
    class Program
    {
        static void Main(string[]args)
        {
            Queue<string> msgs = new Queue<string>();
            msgs.Enqueue("prachi");
            msgs.Enqueue("sayali");
            msgs.Enqueue("akansha");
            msgs.Enqueue("mayuri");
            Console.WriteLine(msgs.Dequeue);
            Console.WriteLine(msgs.Peek());
            Console.WriteLine(msgs.Peek());
            Console.WriteLine();
            foreach(string msg in msgs)
            {
                Console.WriteLine(msg);
            }
        }
    }
}