using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Reverse_Number
    {
        public static void Reverse(int number)
        {
            int remainder = 0, reverse = 0;
            while(number!=0)
            {
                remainder=number % 10;
                reverse = remainder + (reverse * 10);
                number=number/10;
            }
            Console.WriteLine(reverse);
        }
        

    }
}
