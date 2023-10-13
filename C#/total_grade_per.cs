using System;
namespace totalsub
{
    class total
    {
        public static void Main()
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade;
            Console.WriteLine("enter 3 subject marks");
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2 = Convert.ToInt32(Console.ReadLine());
            sub3 = Convert.ToInt32(Console.ReadLine());
            total = sub1 + sub2 + sub3;
            Console.WriteLine("total: " + total);
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("per:" + per);
            if (per > 75)
            {
                grade = "destination";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "first class";
            }
            else
            {
                grade = "fail";
            }
            Console.WriteLine("grade:" + grade);
            Console.ReadKey();
        }
    }
}