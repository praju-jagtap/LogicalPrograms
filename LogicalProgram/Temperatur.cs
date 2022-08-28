using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Temperatur
    {
        int celsius, fahrenheit;
        public void convert()
        {
            Console.Write("\n");
            Console.Write("To Print Temperture Conversion:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("Please enter your choice \n 1.Degree to Fahrenheit \n 2.Fahrenheit to Degree\n");
            Console.Write("----------------------------------------------\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Converting Value From Celsius To Fahrenheit");
                    celsius = Convert.ToInt32(Console.ReadLine());
                    fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine(fahrenheit);
                    break;
                case 2:
                    Console.WriteLine("Converting Value From  Fahrenheit To Celsius");
                    fahrenheit = Convert.ToInt32(Console.ReadLine());
                    celsius = (fahrenheit - 32) * (5 / 9);
                    Console.WriteLine(celsius);
                    break;

                default:
                    break;
            }
        }
    }
}
