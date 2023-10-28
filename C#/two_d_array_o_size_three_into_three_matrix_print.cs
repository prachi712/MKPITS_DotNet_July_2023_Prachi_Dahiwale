using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int i, j;
            int[,] arr1 = new int[3, 3];
            Console.WriteLine("enter numbers");
            for ( i = 0; i < 3; i++)
            {
                for(j=0;j<3;j++)
                {
                    Console.WriteLine("element-{0},{1}:", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("the matrix is:");
            
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arr1[i, j] );
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();
            
        }
       
    }
    
}