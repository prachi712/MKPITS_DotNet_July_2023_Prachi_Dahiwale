using System;


namespace Empprogram
{
    class emp
    {
        public static void Main()
        {
            int empno, basicsalry;
            string empname, designation;
            float bonus = 0, total;
            Console.WriteLine("enter emp number");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter empname");
            empname = Console.ReadLine();
            Console.WriteLine("enter designation");
            designation = Console.ReadLine();
            Console.WriteLine("enter emp basicsalry");
            basicsalry = Convert.ToInt32(Console.ReadLine());
            if (designation == "manager")
            {
                bonus = basicsalry * 0.55f;
            }
            else if (designation == "clerk")
            {
                bonus = basicsalry * 0.25f;
            }
            else if (designation =="peun")
            {
                bonus = basicsalry * 0.10f;

            }
            else
            {
                Console.WriteLine("invalid designation");
            }
            total = basicsalry + bonus;
            Console.WriteLine("empno{0}, empname{1},designation{2},basicsalry{3}", empno, empname, designation, basicsalry);
            Console.Write("bonus{0}, total{1}", bonus, total);
            Console.ReadKey();

        }
    }
}