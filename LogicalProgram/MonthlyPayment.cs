using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class MonthlyPayment
    {
        double P, Y, R, n, r, payment;  
        public void Payment()            
        {
            Console.WriteLine("Enter Principle Amount", P);  
            P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number Of Year", Y);
            Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate Of Interest", R);
            R = Convert.ToDouble(Console.ReadLine());
            n = (12 * Y);
            Console.WriteLine("Number: " + n);
            r = R / (12 * 100);
            Console.WriteLine("Rate: " + r);
            payment = ((P * r) / (1 - Math.Pow(1 + r, -n)));
            Console.WriteLine("Monthly Payment: " + payment);
        }
    }
}

