namespace Logical_Programs
{
    public class PerfectNumber
    {
        public static void perfectnum(int num)
        {
            int sum = 0;
            for (int i=1;i<= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    //Console.WriteLine(sum);
                }
            }
            if (sum == num)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not a Perfect Number");

         

        }
    }
}