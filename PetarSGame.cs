using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetarSGame
{
    class PetarSGame
    {
        static void Main(string[] args)
        {
            ulong startNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            ulong sum = 0;
            string replace;
            for(ulong i = startNumber; i < endNumber; i++)
            {
                if(i % 5 == 0)
                {
                    sum = sum + i;
                }
                else
                {
                    sum = sum + (i % 5);
                }
            }
            if (sum % 2 == 1)
            {
                replace = sum.ToString()[sum.ToString().Length - 1].ToString();
            }
            else
            {
                replace = sum.ToString()[0].ToString();
            }
            Console.WriteLine(sum.ToString().Replace(replace, str));  
        }
    }
}
