using System;
using System.collections;
namespace program
{
    class Program
    {
        static void Main (string[]args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "prachi");
            ht.Add("2", "swayam");
            ht.Add("3", "sayyam");
            ht.Add("4", "pratiksha");
            if(ht.ContainsValue("neha"))
            {
                Console.WriteLine("name already in list");
            }else
            {
                ht.Add("5", "neha");
            }
            ICollection Key = ht.Keys;
            foreach(string s in key )
            {
                Console.WriteLine(s + ":" + ht[s]);

            }
            Console.ReadKey();

        }
    }
}