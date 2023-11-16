using System;
namespace program
{
    public class person
    {
        public string name = "prachi";
        public string address = "nagpur";
    }
    public class employee : person
    {
        public int empno=123;
        
        public int salary=1111111;
        public string designation = "manager";
    }
    class program
    {
        public static void Main(string[]args)
        {
            employee s1 = new employee();
            Console.WriteLine("name:" + s1.name);
            Console.WriteLine("address:" + s1.address);
            
            Console.WriteLine("empno:" + s1.empno);
            Console.WriteLine("designation:" + s1.designation);
        }
    }
}