namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int options,num;

            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("Choose Given options for respective Programs to Run");
            Console.WriteLine("1 - Fibonaaci Program");
            options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Enter Number to which Fibonaaci series to be printed");
                    num = Convert.ToInt32(Console.ReadLine());
                    Fibonaaci.fib(num);
                    break;

            }
        }
    }
}