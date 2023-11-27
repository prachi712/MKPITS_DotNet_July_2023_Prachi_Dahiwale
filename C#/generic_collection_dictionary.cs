using System;
using System.Collections.Generic;
namespace program
{
    class Program
    {
        static void Main(string[]args)
        {
            Dictionary<string, string> domains = new Dictionary<string, string>();
            domains.Add("de", "demon");
            domains.Add("In", "india");
            domains.Add("Uk", "america");
            domains.Add("pk", "pakistan");
            Console.WriteLine(domains["de"]);
            Console.WriteLine(domains["In"]);
            Console.WriteLine("Dictionary has {0} items", domains.Count);
            Console.WriteLine("keys of the dictionary");
            List<string> keys = new List<string>(domains.Keys);

            foreach(string key in keys)
            {
                Console.WriteLine("{0}", key);
            }
            Console.WriteLine("values of dictionary");
            List<string> Values = new List<string>(domains.Values);
            foreach(string sa in Values)
            {
                Console.WriteLine("{0}", sa);
                Console.WriteLine("keys and values in dictionary");
                foreach(KeyValuePair<string,string>kvp in domains)
                {
                    Console.WriteLine("key{0},value={1}", kvp.Key, kvp.Value );
                }
            }


        }
    }
}