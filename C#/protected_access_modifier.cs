using System;
namespace program
{
    public class person
    {
        string name;
        string address;
        protected void getpersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected void displaypersonData()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("address:" + address);
        }
    }
    public class student:person
    {
        int rno;
        int marks;
        public void getstudentData(int rno,int marks)
        {
            getpersonData("prachi", "nagpur");
            this.rno = rno;
            this.marks = marks;
        }
        public void displaystudentData()
        {
            displaypersonData();
            Console.WriteLine("rno" + rno);
            Console.WriteLine("marks" + marks);
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            student s1 = new student();
            s1.getstudentData(111, 99);
            s1.displaystudentData();
        }
    }
}