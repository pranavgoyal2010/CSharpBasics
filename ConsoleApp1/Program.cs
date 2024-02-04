// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(item);
            Console.WriteLine(youngestChild(child2: "John", child3: "Nathan", child1: "Victor"));
            Console.WriteLine(youngestChild("Sam"));
            Console.WriteLine(multiply(3, 12));
        }

        static string youngestChild(string child1, string child2, string child3)
        {
            //var item = 5;
            return "the youngest child is " + child3;
        }

        static string youngestChild(String name = "Harry")
        {
            return "the name is " + name;
        }

        static int multiply(int x, int y)
        {
            return x * y;
        }

        static double multiply(double x, double y)
        {
            return x * y;
        }
    }
}
