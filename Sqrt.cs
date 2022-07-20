namespace Logical_Programs
{
    public class Sqrt
    {
        public static void sqrtcal(int c)
        {
            double t = c;
            double epsilon = 1e-15;
            while(Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine("Square root = " + t);

         

        }
    }
}