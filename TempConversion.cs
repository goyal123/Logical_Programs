namespace Logical_Programs
{
    public class TempConversion
    {
        public static void temptocelcius(double temp)
        {
            double temp_celcius;
            temp_celcius = ((temp - 32)*5)/9;
            Console.WriteLine("Temparatre in celcius = " + temp_celcius);
        }
        public static void temptoFaren(double temp)
        {
            double temp_faren;
            temp_faren = (temp * 9)/5 + 32;
            Console.WriteLine("Temperature in Farenheit = " + temp_faren);
        }
    }
}