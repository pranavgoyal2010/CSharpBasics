// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    static class product
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;

        static product()
        {
            ProductId = 1;
            ProductName = "Guitar";
            ProductPrice = 5000;
        }

        //will give error as cannot have instance methods in static class
        /*public void getProductDetails()
        {

        }*/
        public static void getProductDetails()
        {
            Console.WriteLine("Product ID = {0}", ProductId);
            Console.WriteLine("Product Name = {0}", ProductName);
            Console.WriteLine("Product Price = {0}", ProductPrice);
        }

        public static void getDiscount() 
        {
            int d_amount = ProductPrice / 10;
            Console.WriteLine("Your discount amount is: {0}", d_amount);
            Console.WriteLine("Total cost of product is {0}", (ProductPrice-d_amount));
        }
    }

    //will give error as cannot inherit a static class
    /*class items : product
    {

    }*/
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //will give error as you can't instantiate a static class
            //product p = new product();


            product.getProductDetails();
            product.getDiscount();
           
        }
    }
}
