using System;
using System.Globalization;
using System.Threading;

class FriendBits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        uint num = uint.Parse(Console.ReadLine());
        uint frendBits = 0;
        uint aloneBits = 0;
        uint previousBit = 0;
        bool wasTheSame = false;
        for (int bit = 31; bit >= 0; bit--)
        {
            uint currentBit = num >> bit & 1;
            if (bit == 31)
            {
                previousBit = currentBit;
            }
            else if (bit == 0)
            {
                if (currentBit == previousBit)
                {
                    frendBits <<= 1;
                    frendBits |= previousBit;
                    frendBits <<= 1;
                    frendBits |= currentBit;
                }
                else
                {
                    if (wasTheSame)
                    {
                        frendBits <<= 1;
                        frendBits |= previousBit;
                        aloneBits <<= 1;
                        aloneBits |= currentBit;
                    }
                    else
                    {
                        aloneBits <<= 1;
                        aloneBits |= previousBit;
                        aloneBits <<= 1;
                        aloneBits |= currentBit;
                    }
                }
            }
            else
            {
                if (currentBit == previousBit)
                {
                    frendBits <<= 1;
                    frendBits |= previousBit;
                    wasTheSame = true;
                    previousBit = currentBit;
                }
                else
                {
                    if (wasTheSame)
                    {
                        frendBits <<= 1;
                        frendBits |= previousBit;
                        wasTheSame = false;
                        previousBit = currentBit;
                    }
                    else
                    {
                        aloneBits <<= 1;
                        aloneBits |= previousBit;
                        previousBit = currentBit;
                    }
                }
            }
        }
        Console.WriteLine(frendBits);
        Console.WriteLine(aloneBits);
    }
}
