using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNo
    {

        int numCheck = 1, sum = 0,i ;
        public void Perfect()
        {
            Console.Write("\n");
            Console.Write("To Print Perfect no:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("Enter The Number To Check Either its Perfect No or Not:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num/2; i++)
            {
                numCheck = num % i; 
                if (numCheck == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("Number is Perfect Number");
            }
            else
            {
                Console.WriteLine("Number is Not a Perfect Number");
                Console.ReadLine();
            }
        }
    }
}
