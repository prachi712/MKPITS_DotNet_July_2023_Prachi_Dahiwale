using System;
namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {
            
            int sum = 0;
            for (int counter = 1; counter <= 10; counter++)
            {
                sum = sum + counter;
                Console.WriteLine(" natural number is:" +counter);
                
            }
            
            Console.WriteLine("the total sum is:" +sum);
            Console.ReadKey();
        }
        
       
    }
    
}