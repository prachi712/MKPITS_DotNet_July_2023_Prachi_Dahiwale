using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] arr1= new int[3];
            int[] arr2 = new int[3];
            

            Console.WriteLine("input the number of elements stored in the array:3");
            Console.WriteLine("input 3 elements in array");


            for (int i = 0; i < 3; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("element-{0}={1}", i, arr1[i]);
            }
            Console.WriteLine("\t");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("element-{0}={1}", i, arr1[i]);


            }
            Console.WriteLine("\t");
            Console.WriteLine("the elements are stored in first array are:");
            for (int i = 0; i < 3; i++)
            {
                arr2[i] = arr1[i];
                Console.Write(arr1[i]);

            }
            Console.WriteLine("\t");
            Console.WriteLine("elements copied in the array are");
            for(int i=0;i<3;i++)
            {
                arr1[i] = arr2[i];
                Console.Write(arr2[i]);
            }
            Console.ReadKey();
            
        }
    }
}