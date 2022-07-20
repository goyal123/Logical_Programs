namespace Logical_Programs
{
    public class BinarytoDecimal:DecimaltoBinary
    {
        public string binary;
        public BinarytoDecimal(int num)
        {
            binary=DectoBin(num);
            //Console.WriteLine("inside constructor = "+binary);  
        }
        public double BintoDec(string binary)
        {
            //Console.WriteLine("inside function = " + binary);
            double num=0;
            string newrem = "";

            for(int i=4;i<binary.Length;i++)
            {
                newrem = newrem + binary[i];
            }
            for(int i=0;i<4;i++)
            {
                newrem=newrem + binary[i];
            }

            //Console.WriteLine("Newbinary = " + newrem);

            for(int i=newrem.Length-1;i>=0;i--)
            {
                if(newrem[i] == '1')
                {
                    //Console.WriteLine("At i = " + i);
                    num = num + Math.Pow(2,(7-i));
                    //Console.WriteLine(num);
                }
            }
            return num;
            //Console.WriteLine("Decimal Conversion of swapped nibbles = "+num);
        }

    }
}