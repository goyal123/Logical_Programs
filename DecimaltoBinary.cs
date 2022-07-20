namespace Logical_Programs
{
    public class DecimaltoBinary
    {
        public static string DectoBin(int num)
        {
            string rem = "";
            
            while (num > 1)
            {
                int remainder = num % 2;
                num = num / 2;
                rem = Convert.ToString(remainder) + rem;
            }
            rem = Convert.ToString(num) + rem;
            if (rem.Length < 9)
            {
                var len = 8 - rem.Length;

                for (int i = 0; i < len; i++)
                {
                    rem = '0' + rem;
                }
            }
            return rem;
        }
    }
}



            