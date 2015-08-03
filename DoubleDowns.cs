using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDowns
{
    class DowbleDowns
    {
        static void Main(string[] args)
        {
            byte amount = byte.Parse(Console.ReadLine());
            int[] numbers = new int[amount];
            int rightDiagonal = 0;
            int leftDiagonal = 0;
            int vertikal = 0;
            for(int i = 0; i < amount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for(int q= 0; q < numbers.Length - 1; q++)
            {
                int topNumber = numbers[q];
                int bottomNumber = numbers[q + 1];
                for(int bit = 0; bit < 32; bit++)
                {
                    int mask = 1 << bit;
                    bool checkTopBit = (topNumber & mask) > 0;
                    if(checkTopBit && (bottomNumber & (mask >> 1)) > 0)
                    {
                        rightDiagonal++;
                    }
                    if(checkTopBit && (bottomNumber & (mask << 1)) > 0)
                    {
                        leftDiagonal++; 
                    }
                    if(checkTopBit && (bottomNumber & mask) > 0)
                    {
                        vertikal++;
                    }
                }
            }
            Console.WriteLine(rightDiagonal);
            Console.WriteLine(leftDiagonal);
            Console.WriteLine(vertikal);
        }
    }
}
