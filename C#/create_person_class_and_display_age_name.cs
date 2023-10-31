using System;
namespace Program
{
    class person
    {
        string person_name;
        int person_age;
        string person_add;
        public void getdata(string pn, int pa, string pd)
        {
            person_name = pn;
            person_age = pa;
            person_add = pd;
        }
        public void displaydata()
        {
            Console.WriteLine("person name:" + person_name);
            Console.WriteLine("person age:" + person_age);
            Console.WriteLine("person add:" + person_add);
        }

    }
    class program
    {
        public static void Main(string[]args)
        {
            person per = new person();
            per.getdata("prachi", 24, "bhandara");
            per.displaydata();
            Console.ReadKey();
        }
    }
}