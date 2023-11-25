using System;
using System.Collections;
namespace program
{
    class Program
    {
        static void Main(string[]args)
        {
            Stack st = new Stack();
            st.Push("prachi");
            st.Push("swayam");
            st.Push("sayyam");
            st.Push("pratiksha");
            Console.WriteLine("current stack:" +"\n");
            foreach(string str in st)
            {
                Console.Write(str );

            }
            Console.WriteLine();
            st.Push("akbar");
            st.Push("antheny");
            Console.WriteLine("the next poppable song:{0}", st.Peek);
            Console.WriteLine("current stack:");
            foreach( string str in st)
            {
                Console.Write(str + "");

            }
            Console.WriteLine("removing values");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("current stack:");
            foreach(string str in st)
            {
                Console.Write(str +"");
            }
        }
    }
}