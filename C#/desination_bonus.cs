using System;
namespace bonusprogram
{
    class program
    {
        public static void Main(string[]args)
        {
            string designation;
            int bonus = 0;
            Console.WriteLine("enter designation manager,clerk,peun");
            designation = Console.ReadLine();
            switch(designation)
            {
                case "manager":
                    bonus = 50000;
                    break;
                case "clerk":
                    bonus = 200000; 
                    break;
                case "peon":
                    bonus = 1000; ;
                    break;
                default:
                    Console.WriteLine("invalid designation");
                    break;


            }
            Console.WriteLine("bonus={0}", bonus);
            Console.ReadKey();
        }
    }
}