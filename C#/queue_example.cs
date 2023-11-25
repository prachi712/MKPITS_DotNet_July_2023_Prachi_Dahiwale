using System;
using System.Collections;
namespace program
{
    class Program
    {
        static void Main(string[]args)
        {
            Queue q = new Queue();
            q.Enqueue("prachi");
            q.Enqueue("swayam");
            q.Enqueue("sayyam");
            q.Enqueue("pratiksha");
            Console.WriteLine("current queue:");
            foreach(string str in q)
            {
                Console.Write(str "");
                Console.WriteLine();
                q.Enqueue("mrunal");
                q.Enqueue("rita");
                Console.WriteLine("removing some values");
                string str = (string)q.Dequeue();
                Console.WriteLine("the removed value:{0}", str);
                str = (string)q.Dequeue();
                Console.WriteLine("the removed value{0}:" ,str);
                Console.ReadKey();
            }
        }
    }
}