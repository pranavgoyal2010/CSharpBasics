// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    
    class Example
    {
        public static int a;
        private Example() 
        {
        }
        public static int getIncrement()
        {
            return ++a;
        }
        public static void getTime() 
        {
            Console.WriteLine(DateTime.Now);
        }
    }

    //class Example2 : Example
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Example e = new Example();
            Example.getTime();
            Console.WriteLine(Example.getIncrement());
        }
    }
}
