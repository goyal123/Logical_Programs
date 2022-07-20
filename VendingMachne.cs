namespace Logical_Programs
{
    public class VendingMachine
    {
        public static void machine(int amount)
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2 , 1 };
            int[] notescounter = new int[8];

            for (int i=0;i<8;i++)
            {
                if(amount >= notes[i])
                {
                    notescounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }

            for(int i=0;i<8;i++)
            {
                if (notescounter[i]!=0)
                {
                    Console.WriteLine("Count of "+ notes[i] + " notes = " + notescounter[i]);
                }
            }

        }
    }
}