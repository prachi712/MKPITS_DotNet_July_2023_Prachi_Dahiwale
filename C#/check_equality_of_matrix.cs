using System;
namespace Program
{
    class program
    {
        static void Main(string[]args)
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int row, col;
            int flag = 0;
            Console.WriteLine("enter 1 matrix");
            for(row=0;row<2;row++)
            {
                for(col=0;col<2;col++)
                {
                    Console.WriteLine("Element:[{0}],[{1}]:", row, col);
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("enter two matrix");
            for(row=0;row<2;row++)
            {
                for (col = 0; col < 2; col++)
                {
                    Console.Write("element [{0}]=[{1}]", row, col);
                    arr2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(row=0;row<2;row++)
            {
                for(col=0;col<2;col++)
                {
                    if (arr1[row, col] == arr2[row,col])
                    {
                        flag = 1;
                        break;
                    }
                }
            }
            if (flag == 1)
            {
                Console.Write("matrix are equal");
            }
            else
            {
                Console.Write("matrix are not equal");
            }
            Console.ReadKey();
        }
    }
}