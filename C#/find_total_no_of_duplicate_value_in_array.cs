using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;

namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {

            int cnt = 0;
            int[] arr1= new int[3];
            
          
            Console.WriteLine("input the number of elements stored in the array:3");
            Console.WriteLine("input 3 elements in array");
            

            for (int i = 0; i < 3; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                
                
            }
            Console.Write("\n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("element-{0}={1}", i, arr1[i]);


            }
            
            
             for(int i=0;i<3;i++)
            {
                

                for (int j=i+1;j<3;j++)
                {

                    if (arr1[i] == arr1[j])
                    {
                        cnt++;
                        break;
                    }
                }
                
             }
            Console.WriteLine("total number of duplicate are:"+cnt);

            Console.ReadKey();
        }
          
    }
}