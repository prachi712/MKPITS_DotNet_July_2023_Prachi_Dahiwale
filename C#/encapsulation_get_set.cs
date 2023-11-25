using System;
namespace program
{
    class employee
    {
        public string empname { get; set; }
    }
    class program
    {
        public static void Main(string[]args)
        {
            employee emp = new employee();
            emp.empname = "prachi";
            Console.WriteLine("empname" + emp.empname);
        }
    }
}