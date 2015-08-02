using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling
{
    class Gambling
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            string[] cards = Console.ReadLine().Split();
            int housesStrength = 0;
            foreach(var card in cards)
            {
                switch(card)
                {
                    case "J":
                        housesStrength += 11;
                        break;
                    case "Q":
                        housesStrength += 12;
                        break;
                    case "K":
                        housesStrength += 13;
                        break;
                    case "A":
                        housesStrength += 14;
                        break;
                    default: housesStrength += int.Parse(card);
                        break;
                }
            }
            int counterWining = 0;
            int totalHands = 0;
            for(int card1 = 2; card1 < 15; card1++)
            {
                for(int card2 = 2; card2 < 15; card2++)
                {
                    for(int card3 = 2; card3 < 15; card3++)
                    {
                        for(int card4 = 2; card4 < 15; card4++)
                        {
                            int myPower = card1 + card2 + card3 + card4;
                            if(myPower > housesStrength)
                            {
                                counterWining++;
                            }
                            totalHands++;
                        }
                    }
                }
            }
            decimal propability = (decimal)counterWining / totalHands;
            if(propability < 0.5m)
            {
                Console.WriteLine("FOLD");
            }
            else
            { 
                Console.WriteLine("DRAW");
            }
            decimal winings = propability * 2 * cash;
            Console.WriteLine("{0:f2}", winings);
        }
    }
}
