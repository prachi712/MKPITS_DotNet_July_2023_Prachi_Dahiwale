using System;
namespace program
{
    public class person
    {
        string name;
        string address;
        public void getpersonData(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersonData()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("addresss:" + address);
        }
    }
    public class student : person
    {
        int rno;
        int marks;
        public void getstudentData(int rno,int marks)
        {
            this.rno=rno;
            this.marks = marks;

        }
        public void displaystudentData()
        {
            Console.WriteLine("rno:" + rno);
            Console.WriteLine("marks:" + marks);
        }
    }
    class program
    {
        public static void Main(string[]args)
        {

            student p1 = new student();
            p1.getpersonData("prachi", "nagpur");
            p1.getstudentData(111, 30);
            p1.displaystudentData();
            p1.displaypersonData();
        }
    }
}