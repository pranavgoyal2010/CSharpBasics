// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    class ParentClass
    {
        public ParentClass(string message) 
        {
            Console.WriteLine(message);
        }
        public ParentClass(int i) 
        {
            Console.WriteLine(i);
        }
    }

    class DerivedClass : ParentClass
    {
        public DerivedClass() : base("How are you?")
        {
            Console.WriteLine("This is derived class constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
        }
    }
}
