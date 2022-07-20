using System.Diagnostics;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int options,num,day,month,year;
            double temp;

            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("Choose Given options for respective Programs to Run");
            Console.WriteLine("1 - Generate Fibonaaci Series");
            Console.WriteLine("2 - Check Perfect Number");
            Console.WriteLine("3 - Check Perfect Number");
            Console.WriteLine("4 - Generate Reverse of Number");
            Console.WriteLine("5 - Coupon check");
            Console.WriteLine("6 - Vending Machine");
            Console.WriteLine("7 - Find Day of week");
            Console.WriteLine("8 - Tempearature Conversion");

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

                case 6:
                    watch.Start();
                    Console.WriteLine("Enter the amount");
                    num = Convert.ToInt32(Console.ReadLine());
                    VendingMachine.machine(num);
                    watch.Stop();
                    break;

                case 7:
                    watch.Start();
                    Console.WriteLine("Enter the date");
                    var date = Console.ReadLine();
                    var new_date = date.Split(',');

                    day = Convert.ToInt32(new_date[0]);
                    month = Convert.ToInt32(new_date[1]);
                    year = Convert.ToInt32(new_date[2]);

                    dayofweek.findday(day, month, year);

                    watch.Stop();
                    break;

                case 8:
                    watch.Start();
                    Console.WriteLine("Enter one of the below options");
                    Console.WriteLine(" 1 - Farenheit to Celcius Conversion ");
                    Console.WriteLine(" 2 - Celcuis to Farenheit Conversion ");
                    var ans = Convert.ToInt32(Console.ReadLine());
                    if (ans==1)
                    {
                        Console.WriteLine("Enter the Temperature");
                        temp = Convert.ToDouble(Console.ReadLine());
                        TempConversion.temptocelcius(temp);
                    }
                    else
                    {
                        Console.WriteLine("Enter the Temperature");
                        temp = Convert.ToDouble(Console.ReadLine());
                        TempConversion.temptoFaren(temp);
                    }
                    watch.Stop();
                    break;


            }
            
            Console.WriteLine("Elasped Time = "+watch.ElapsedMilliseconds);
        }
    }
}