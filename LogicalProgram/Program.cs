namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FibonacciSeries \n2.Perfect Number \n3.Prime Number \n4.Reverse Number \n5.Temperature Conversion \n6.Monthly Payment \n7.Day of Week \n8.Coupon Number");
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
                case 5:
                    Temperatur temperatur = new Temperatur();
                    temperatur.convert();
                    break;
                case 6:
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    monthlyPayment.Payment();
                    break;
                case 7:
                    DayOfWeek dayOfWeek = new DayOfWeek();
                    dayOfWeek.Days();
                    break;
                case 8:
                    CouponNo coupan = new CouponNo();
                    coupan.Dist();
                    break;

                default:
                    break;
            }
        }
    }
}
