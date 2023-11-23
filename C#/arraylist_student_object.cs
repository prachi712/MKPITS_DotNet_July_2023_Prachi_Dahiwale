using System;
using System.Collections;
namespace program
{
    class student
    {
        public int rno;
        public string name;
        public student(int rno,string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            student s1 = new student(1, "Bhashkar");
            student s2=new student(2, "prachi");
            student s3 = new student(3, "dahiwale");
            ArrayList ar = new ArrayList();
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);
            foreach(student s in ar)
            {
                Console.WriteLine("rno:" + s.rno);
                Console.WriteLine("name:" + s.name);
            }
        }
    }
}