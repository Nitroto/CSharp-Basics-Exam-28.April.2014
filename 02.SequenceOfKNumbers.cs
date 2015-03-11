using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class SequenceOfKNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] userInput = Console.ReadLine().Split(' ');
        int[] numbers = new int[userInput.Length];
        int k = int.Parse(Console.ReadLine());
        bool areTheSame = false;
        List<int> result = new List<int>();
        if (k > 1)
        {
            for (int i = 0; i < userInput.Length;)
            {
                int currentNum = int.Parse(userInput[i]);
                for (int j = 1; j < k; j++)
                {
                    if ((i + j) < userInput.Length)
                    {
                        areTheSame = currentNum == int.Parse(userInput[i + j]);
                        if (!areTheSame)
                        {
                            break;
                        }
                    }
                    else
                    {
                        areTheSame = false;
                    }
                }
                if (areTheSame)
                {
                    i += (k);
                }
                else
                {
                    result.Add(currentNum);
                    i++;
                }
            }
        }
        foreach (int num in result)
        {
            Console.Write("{0} ", num);
        }

    }
}
