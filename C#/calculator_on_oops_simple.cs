using System;
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
            if(num!=0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("error:cannot divide by zero");
            }
        }
        public void Clear()
        {
            Result = 0;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            calculator mycalculator = new calculator();
            mycalculator.Add(5);
            Console.WriteLine("Result:" + mycalculator.Result);
            mycalculator.subtract(2);
            Console.WriteLine("Result:" + mycalculator.Result);
            mycalculator.multiply(3);
            Console.WriteLine("Result:" + mycalculator.Result);
            mycalculator.divide(2);
            Console.WriteLine("Result:" + mycalculator.Result);
            mycalculator.Clear();
            Console.WriteLine("Result after clearing :" + mycalculator.Result);
        }
    }
}
