using System.Diagnostics;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int options,num;

            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("Choose Given options for respective Programs to Run");
            Console.WriteLine("1 - Generate Fibonaaci Series");
            Console.WriteLine("2 - Check Perfect Number");
            Console.WriteLine("3 - Check Perfect Number");
            Console.WriteLine("4 - Generate Reverse of Number");
            Console.WriteLine("5 - Coupon check");

            Stopwatch watch = new Stopwatch();

            options = Convert.ToInt32(Console.ReadLine());
           
            switch (options)
            {
                case 1:
                    watch.Start();
                    Console.WriteLine("Enter Number to which Fibonaaci series to be printed");
                    num = Convert.ToInt32(Console.ReadLine());
                    Fibonaaci.fib(num);
                    watch.Stop();
                    break;

                case 2:
                    watch.Start();
                    Console.WriteLine("Enter Number to check");
                    num=Convert.ToInt32(Console.ReadLine());   
                    PerfectNumber.perfectnum(num);
                    watch.Stop();
                    break;

                case 3:
                    watch.Start();
                    Console.WriteLine("Enter Number to check");
                    num = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.primenum(num);
                    watch.Stop();
                    break;

                case 4:
                    watch.Start();
                    Console.WriteLine("Enter Number to reverse");
                    num = Convert.ToInt32(Console.ReadLine());
                    Reverse_Number.Reverse(num);
                    watch.Stop();
                    break;

                case 5:
                    watch.Start();
                    Console.WriteLine("Enter 2 digit Coupon Number");
                    num = Convert.ToInt32(Console.ReadLine());
                    Coupon.coupongen(num);
                    watch.Stop();
                    break;

            }
            
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}