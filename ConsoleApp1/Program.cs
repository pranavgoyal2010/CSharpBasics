// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is second line");
            Console.WriteLine("this is third line");
            Console.WriteLine();

            Console.WriteLine(3 + 3);

            //single line comment 


            /*this
             is 
            multi 
            line
            comment*/

            Console.WriteLine();

            Console.Write("printing 1st ");
            Console.Write("and 2nd sentence on same line");
            Console.WriteLine();
            string str = "abc";
            Console.Write(str);


            Console.WriteLine();

            int myNum = 16;
            Console.WriteLine("The output number is: " + myNum);


            float newNum;
            newNum = 4.55f;
            Console.WriteLine(newNum);

            double num;
            num = 9.99;
            Console.WriteLine(num);


            char ch = 'B';
            Console.WriteLine(ch);
            char ch1 = 'A';
            Console.WriteLine(ch1);

            bool choice, c1, c2;
            choice = c1 = c2 = false;
            Console.WriteLine(c1);

            const int newvariablename = 45;
            //newvariablename = 32;
            Console.WriteLine(newvariablename + 4);

            Console.WriteLine("enter your name");
            str = Console.ReadLine();
            Console.WriteLine(str.Length);

            Console.WriteLine(int.MinValue);

            Console.WriteLine("enter a number");
            myNum = Console.Read();
            Console.WriteLine("The Unicode value of very first digit is " + myNum);


            Console.WriteLine("we are the so called \"Vikings\" from the north");

            int x = 10;
            int y = 9;

            Console.WriteLine(x > y);
            Console.WriteLine(x == 10);

            
        }

        static void Main2(string[] args)
        {
            int minimumAge = 18;
            Console.WriteLine("Enter your age");
            int inputAge = Convert.ToInt32(Console.ReadLine());
            if (inputAge >= minimumAge)
            {
                Console.WriteLine("Can vote");
            }
            else
                Console.WriteLine("Cannot vote");
        }
        static void Main3(string[] args)
        {
            Console.WriteLine(Math.Round(8.4339));
            Console.WriteLine(Math.Round(8.49999));
            Console.WriteLine(Math.Round(8.59999));

            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(9.0D);
            
        }

        static void Main5(string[] args) 
        {
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }

        static void Main(string[] args)
        {
            int i = 0;
            while(i<=5)
            {
                Console.WriteLine(i);
                i++;
            }

            for(int j=0; j<5; j++)
            {
                Console.WriteLine(j);
            }


            int[] array = {1,2,3,4,5,6,7,8};

            for(int j=0; j<8; j+=4)
            {
                int first = j;
                int second = j + 1;
                int third = j + 2;
                int fourth = j + 3;

                int temp = array[first];
                array[first] = array[third];
                array[third] = temp;

                temp = array[second];
                array[second] = array[fourth];
                array[fourth] = temp;
            }

            for(int j=0; j<8; j++)
            {
                Console.Write(array[j]);
            }

        }
    }
}

