namespace Logical_Programs
{
    public class Fibonaaci
    {
        public static void fib(int num)
        {
            int first = 0, second = 1,next=0;
            string ans = first + " " + second;
            while(next<num)
            {
                next = first + second;
                if (next < num)
                    ans = ans + " " + next;
                else
                    break;
                
                first = second;
                second = next;
                //Console.WriteLine(next);
            }
            Console.WriteLine(ans);

        }
    }
}