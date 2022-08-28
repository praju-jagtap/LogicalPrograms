namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FibonacciSeries \n2.Perfect Number \n3.Prime Number \n4.Reverse Number");
            Console.WriteLine("Please Enter Your Choice : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    series.Fibonacci();
                    break;
                case 2:
                    PerfectNo perfectNo = new PerfectNo();
                    perfectNo.Perfect();
                    break;
                case 3:
                    PrimeNo primeNo = new PrimeNo();
                    primeNo.Prime();
                    break;
                case 4:
                    ReverseNo reverseNo = new ReverseNo();
                    reverseNo.Reverse();
                    break;
                
                default:
                    break;
            }
        }
    }
}
