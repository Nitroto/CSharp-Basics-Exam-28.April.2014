using System;
using System.Globalization;
using System.Threading;

class PokerStraight
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int weight = int.Parse(Console.ReadLine());
        int numberOfHandes = 0;
        for (int c1 = 1; c1 < 11; c1++)
        {
            int c2 = c1 + 1;
            int c3 = c2 + 1;
            int c4 = c3 + 1;
            int c5 = c4 + 1;
            for (int s1 = 1; s1 < 5; s1++)
            {
                for (int s2 = 1; s2 < 5; s2++)
                {
                    for (int s3 = 1; s3 < 5; s3++)
                    {
                        for (int s4 = 1; s4 < 5; s4++)
                        {
                            for (int s5 = 1; s5 < 5; s5++)
                            {
                                int currentWeight = (10 * (c1) + s1) + (20 * (c2) + s2) + (30 * (c3) + s3) + (40 * (c4) + s4) + (50 * (c5) + s5);
                                if (currentWeight == weight)
                                {
                                    numberOfHandes++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(numberOfHandes);
    }
}
