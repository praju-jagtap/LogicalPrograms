using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseNo
    {
        int revNum = 0;
        public void Reverse()
        {
            Console.Write("\n");
            Console.Write("To Print Reverse Number:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("Enter No To Print Reverse Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                int reminder = num % 10;
                revNum = revNum * 10 + reminder;
                num = num / 10;
            }
            Console.WriteLine(revNum);
        }
    }
}
