// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function states user's address input.
        int bases;
        int height;

        Console.WriteLine("This program calculates the area of a parallelogram.");
        Console.WriteLine("");
        Console.Write("Enter base: ");
        bases = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height: ");
        height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("The area is: " + (bases * height).ToString("0.00") + " cm².");

        Console.WriteLine("\nDone.");
    }
}