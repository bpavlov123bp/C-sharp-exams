using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Tables
    {
        static void Main(string[] args)
        {
            long bundle1 = long.Parse(Console.ReadLine());
            long bundle2 = long.Parse(Console.ReadLine());
            long bundle3 = long.Parse(Console.ReadLine());
            long bundle4 = long.Parse(Console.ReadLine());
            long tops = long.Parse(Console.ReadLine());
            long tablesToMaded = long.Parse(Console.ReadLine());
            long totalLegs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);
            long tableNeeded = Math.Min((totalLegs / 4), tops);
            if(tableNeeded > tablesToMaded)
            {
                long topsLeft = tops - tablesToMaded;
                long legsLeft = totalLegs - tablesToMaded * 4;
                Console.WriteLine("more: {0}", tableNeeded - tablesToMaded);
                Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
            }
            else if(tableNeeded < tablesToMaded)
            {
                long topsNeedd = tablesToMaded >= tops ? tablesToMaded - tops : 0;
                long legsNeeded = tablesToMaded * 4 >= totalLegs ? tablesToMaded * 4 - totalLegs : 0;
                Console.WriteLine("less: {0}", tableNeeded - tablesToMaded);
                Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeedd, legsNeeded);  
            }
            else
            {
                Console.WriteLine("Just enough tables made: {0}", tableNeeded);
            }
        }
    }
}
