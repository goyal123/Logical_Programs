namespace Logical_Programs
{
    public class MonthlyPay
    {
        public static void emical(int P,double R,int Y)
        {
            double rate = R / 1200;  
            int n = Y * 12;
            double cal = 1/Math.Pow(1 + rate, n);
            double emi;
            emi = (P * rate) / (1 - cal);
            Console.WriteLine("Your Monthly Emi = "+emi);

         

        }
    }
}