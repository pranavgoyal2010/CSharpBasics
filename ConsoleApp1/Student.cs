// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    class Student
    {
        int rollno;
        string name;
        int age;
        int standard;
        
        public void setStudent(int rollno, string name, int age, int standard)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }

        public void getStudent()
        {
            Console.WriteLine("Student's Roll No: " + this.rollno);
            Console.WriteLine("Student's Name: {0}", this.name);
            Console.WriteLine("Student's Age: {0}", this.age);
            Console.WriteLine("Student's Class: " + this.standard);
        }
        static void Main(string[] args)
        {
            Student Adam = new Student();
            Adam.setStudent(46, "Adam", 17, 12);
            Adam.getStudent();
            Console.WriteLine("------------------------------");
            Student John = new Student();
            John.setStudent(56, "John", 16, 11);
            John.getStudent();
        }
    }
}
