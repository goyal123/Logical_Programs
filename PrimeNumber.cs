namespace Logical_Programs
{
    public class PrimeNumber
    {
        public static void primenum(int num)
        {
            int flag = 0;
            for (int i=2;i<= num/2; i++)
            {
                if (num % i == 0)
                {
                    flag= 1;
                    break;
                }
            }
            if (flag==0)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not a Prime Number");

         

        }
    }
}