// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        public abstract void makeSound();
        public void sleep()
        {
            Console.WriteLine("ZZZZZZ.....");
        }
    }

    public class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Bhau Bhau");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.makeSound();
            dog.sleep();
        }
    }
}
