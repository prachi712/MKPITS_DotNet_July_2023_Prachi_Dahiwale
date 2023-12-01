using System;
using System.Diagnostics;

namespace program
{

    public class calculator
    {
        public double Result { get; private set; }
        public void Add(double num)
        {
            Result += num;
        }
        public void subtract(double num)
        {
            Result -= num;
        }
        public void multiply(double num)
        {
            Result *= num;
        }
        public void divide(double num)
        {
            if (num != 0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("error:cannot divide by zero");
            }
        }
        public void Exponentiate(double exponent)
        {
            Result = Math.Pow(Result, exponent);
        }
        public void Squareroot()
        {
            if (Result >= 0)
            {
                Result = Math.Sqrt(Result);
            }
            else
            {
                Console.WriteLine("error:cannot calculate squarerrot of negative numbers ");
            }
        }
        public void Clear()
        {
            Result = 0;
        }
    }
    class program
    {
        static void Main()
        {
            calculator mycalculator = new calculator();
            while (true)
            {
                Console.WriteLine("current result:" + mycalculator.Result);
                Console.WriteLine("1.Add");
                Console.WriteLine("2.substract");
                Console.WriteLine("3.divide");
                Console.WriteLine("4.exponentiate");
                Console.WriteLine("5.squareroot");
                Console.WriteLine("6.multiply");
                Console.WriteLine("7.clear");
                Console.WriteLine("0.Exit");
                Console.WriteLine("enter your choice");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("enter no to add:");
                        double addnum = Convert.ToDouble(Console.ReadLine());
                        mycalculator.Add(addnum);
                        break;
                    case "2":
                        Console.Write("enter no to sunstract:");
                        double subnum = Convert.ToDouble(Console.ReadLine());
                        mycalculator.Add(subnum);
                        break;
                    case "3":
                        Console.Write("enter no to divide:");
                        double dividenum = Convert.ToDouble(Console.ReadLine());
                        mycalculator.Add(dividenum);
                        break;
                    case "4":
                        mycalculator.Clear();
                        break;
                    case "0":
                        Console.WriteLine("existing calculator...goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid choice please try again");
                        break;
                }
                Console.WriteLine();

            }
        }
    }
}          