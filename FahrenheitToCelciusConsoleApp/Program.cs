/*
 *  C# Program to Convert Fahrenheit to Celsius 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            Console.Write("Enter Fahrenheit temperature : ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The Converted Celsius Temperature Is: " + celsius);
            Console.ReadLine();
        }
    }
}