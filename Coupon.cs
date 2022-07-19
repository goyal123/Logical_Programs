using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Coupon
    {
        public static void coupongen(int num)
        {
            int count = 0;

            Random rand = new Random();

            while(rand.Next(0,100)!=num)
            {
                count++;

            }

            Console.WriteLine("count of total random number generated = "+count);
        }
        

    }
}
