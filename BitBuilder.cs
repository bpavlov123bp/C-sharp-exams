using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBuilder
{
    class BitBuilder
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while(command != "quit")
            {
                int possition = int.Parse(command);
                command = Console.ReadLine();
                long mask = 0;
                for(int i = 0; i < possition; i++)
                {
                    mask <<= 1;
                    mask |= 1;
                }
                long rightBits = number & mask;
                switch(command)
                {
                    case "flip":
                        number ^= 1 << possition;
                        break;
                    case "remove":
                        
                        number >>= possition + 1;
                        number <<= possition;
                        number |= rightBits;
                        break;
                    case "insert":
                        number >>= possition;
                        number <<= possition + 1;
                        number |= (long)1 << possition;
                        number |= rightBits;
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(number);
        }
    }
}
