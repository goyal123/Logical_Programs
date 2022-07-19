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

            options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Enter Number to which Fibonaaci series to be printed");
                    num = Convert.ToInt32(Console.ReadLine());
                    Fibonaaci.fib(num);
                    break;

                case 2:
                    Console.WriteLine("Enter Number to check");
                    num=Convert.ToInt32(Console.ReadLine());   
                    PerfectNumber.perfectnum(num);
                    break;

                case 3:
                    Console.WriteLine("Enter Number to check");
                    num = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.primenum(num);
                    break;

                case 4:
                    Console.WriteLine("Enter Number to reverse");
                    num = Convert.ToInt32(Console.ReadLine());
                    Reverse_Number.Reverse(num);
                    break;

                case 5:
                    Console.WriteLine("Enter 2 digit Coupon Number");
                    num = Convert.ToInt32(Console.ReadLine());
                    Coupon.coupongen(num);
                    break;





            }
        }
    }
}