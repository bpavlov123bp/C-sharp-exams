using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nums
{
    class Nums
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double temp = n;
            for(double i = n; i <= m; i++)
            {
               if(i % 2 == 1)
               {
                   Console.WriteLine("{0:f3}", i * i);
               }
               else
               {
                   Console.WriteLine("{0:f3}", Math.Sqrt(i));
               }
            }
        }
    }
}
