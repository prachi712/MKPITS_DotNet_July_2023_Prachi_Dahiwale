using System;
using System.ComponentModel.DataAnnotations;

namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int search = 0;
            int usernum;
            Console.WriteLine("enter number to be searched");
            usernum = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<num.Length;i++)
            {
                if (num[i]==usernum)
                {
                    search = 1;
                    break;
                }
            }
            if(search==1)
            {
                Console.WriteLine("num {0} is found an array", usernum);
            }
            else
            {
                Console.WriteLine("number is not found in an array");
            }
            Console.ReadKey();
        }
    }
}