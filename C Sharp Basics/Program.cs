// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Write() method, which is similar to WriteLine().

        //The only difference is that it does not insert a new line at the end of the output

        Console.WriteLine("Hello, World!");
        Console.Write("Print same line. ");
        Console.Write("Again...");

        // Variables: type variableName = value;
        // string, char, bool, int, double
        int num = 30;
        double decimalNum = 15.99;
        string name = "John";
        char grade = 'A';
        bool pass = true;

        // If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.
        // You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided

        const int height = 10;
        //height = 20;  // error

        //To declare more than one variable of the same type, use a comma-separated list:

        int x = 5, y = 10, z = 0;


        //Type casting: implicit and explicit 
        int a = 10;
        double b = a; // implicit 

        string c = Convert.ToString(b);  // explicit 
        Console.WriteLine(c);


        // ReadLine() method is used to get user inputs from console
        // but it returns value in string so u have to convert string to int
        Console.WriteLine("Enter age: ");

        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your Age is " + age);


    }
}


