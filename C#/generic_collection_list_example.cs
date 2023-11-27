using System;
using System.Collections.Generic;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();
            langs.Add("csharp");
            langs.Add("java");
            langs.Add("python");
            langs.Add("ruby");
            langs.Add("web");
            Console.WriteLine(langs.Contains("csharp"));
            Console.WriteLine(langs[1]);
            Console.WriteLine(langs[2]);
            langs.Remove("csharp");
            langs.Remove("ruby");
            Console.WriteLine(langs.Contains("csharp"));
            langs.Insert(3, "cyber");
            langs.Sort();
            foreach(string s in langs)
            {
                Console.WriteLine(s);
            }
        }
    }

}