namespace Logical_Programs
{
    public class DecimaltoBinary
    {
        public static void DectoBin(int num)
        {
          string rem="";
          while(num>1)
            {
                int remainder = num % 2;
                num = num / 2;
                rem = Convert.ToString(remainder)+rem;
            }
            rem=Convert.ToString(num)+rem;
            Console.WriteLine("Binary Equivaent = "+rem);
        }
    }
}