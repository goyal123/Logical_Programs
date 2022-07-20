namespace Logical_Programs
{
    public class dayofweek
    {
        public static void findday(int d, int m, int y)
        {
            int[] t = { 0, 3, 2, 5, 0, 3, 5,1, 4, 6, 2, 4 };
            int day;
            y -= (m < 3) ? 1 : 0;
            day = (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7;
            switch(day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Not a day");
                    break;

            }
            
        }
    }
}