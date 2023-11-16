using System;
namespace program
{
    class person
    {
        public string name;
        public string address;
    }
    class student : person
    {
        public int rno;
        public int marks;
    }
    class testinheritance
    {
        public static void Main(string[]args)
        {
            student s1 = new student();
            s1.name = "swayam";
            s1.rno = 123;
            s1.address = "jawaharnagar";
            s1.marks = 250;
            Console.WriteLine("name:" + s1.name);
            Console.WriteLine("rno: " + s1.rno);
            Console.WriteLine("marks:" + s1.marks);
            Console.WriteLine("address:" + s1.address);
        }
    }
}