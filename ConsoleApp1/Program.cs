// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    //Single Inheritance
    class BaseClass
    {
        public void Show1()
        {
            Console.WriteLine("This is base class method");
        }
    }

    class DerivedClass1 : BaseClass
    {
        public void Show2()
        {
            Console.WriteLine("This is derived 1 class method");
        }
    }

    //Multilevel Inheritance
    class DerivedClass2 : DerivedClass1
    {
        public void show3()
        {
            Console.WriteLine("this is dervied 2 class method");
        }
    }


    //Hierarchical Inheritance
    class VisitingEmployees : Employees
    {
        public int visitingSalary;
        public int visitingHours;
    }

    class PermanentEmployees : Employees
    {
        public int permanentSalary;
        public int permanentHours;
    }

    class Employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;
        
        public void show()
        {
            Console.WriteLine("this is a method in base class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            PermanentEmployees John = new PermanentEmployees();
            John.EmpId = 10;
            John.show();
            VisitingEmployees Tom = new VisitingEmployees();
            Tom.EmpId = 20;

            Console.WriteLine(John.EmpId);
            Console.WriteLine(Tom.EmpId);

            DerivedClass1 dc1 = new DerivedClass1();
            dc1.Show1();
            dc1.Show2();

            DerivedClass2 dc2 = new DerivedClass2();
            dc2.Show1();
            dc2.Show2();
            dc2.show3();
        }
    }
}
