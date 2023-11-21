using System;
namespace program
{
    interface ILogger
    {
        string LogMessage(string message);
        string LogError(string error);
    }
    class logger:ILogger
    {
        public string LogMessage(string message)
        {
            return "message";
        }
  
        public string LogError(string error)
        {
            return "errormessage";
        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            ILogger l;
            l = new logger();
             string res = l.LogMessage("hellow");
            Console.WriteLine(res);
            res = l.LogError("error message");
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}