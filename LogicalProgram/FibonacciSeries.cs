using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class FibonacciSeries
    {
        int firstNum = 0, secondNum = 1, thirdNum = 0;
        public void Fibonacci()
        {
            Console.Write("\n");
            Console.Write("To Print Febonacci Series:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("Enter the Number to Print FibonacciSeries : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Febonacci Series is : \n" + firstNum + "\n" + secondNum);
            while (num >= 2)
            {
                thirdNum = firstNum + secondNum;
                Console.WriteLine(thirdNum + "");
                firstNum = secondNum;
                secondNum = thirdNum;
                num--;
            }
        }
    }
}
