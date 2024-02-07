// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    public interface Bank
    {
        public void deposit (double amount);
        public void withdraw(double amount);

        public void display();   
    }

    public class XYZ : Bank
    {
        private double currentBalance;
        public void deposit(double amount)
        {
            if(amount<=0)
                Console.WriteLine("Invalid entry");

            else
            {
                currentBalance += amount;
                Console.WriteLine("Amount {0} added", amount);
            }
        }
        public void withdraw(double amount)
        {
            if (amount <= 0)
                Console.WriteLine("Invalid entry");

            else
            {
                currentBalance -= amount;
                Console.WriteLine("Amount {0} withdrawn", amount);
            }
        }

        public void display() 
        {
            Console.WriteLine("The current balance: " + currentBalance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            XYZ John = new XYZ();
            John.deposit(0);
            John.deposit(100.34);
            John.withdraw(100);
            John.display();
        }
    }
}
