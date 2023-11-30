using System;
using System.Collections.Generic;
namespace progam
{
    class program
    {
        static void Main(string[]args)
        {
            int[] arr = new int[3];
            arr[0] = 22;
            arr[1] = 25;
            arr[2] = 30;
            try
            {
                for(int i=0;i<=3;i++)
                {
                    Console.WriteLine("arr=" + arr[i]);
                }
            }
            catch(IndexOutOfRangeException ee)
            {
                Console.WriteLine("catch block is executing");
                Console.WriteLine(ee.ToString());
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("block is executing");
            }
            Console.WriteLine("bye");
        }
    }
}