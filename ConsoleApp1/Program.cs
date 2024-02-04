// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{

    class Example
    {
        string name;
        int age;

        public Example(string name, int age) 
        { 
            this.name = name;
            this.age = age;
        }

        public Example(Example example) //copy constructor
        {
            this.name = example.name;
            this.age = example.age;
        }

        public void getData()
        {
            Console.WriteLine("Name is {0}", this.name);
            Console.WriteLine("Age is {0}", this.age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example("John", 23);
            example.getData();
            Example example1 = new Example(example);
            example1.getData();
        }
    }
}
