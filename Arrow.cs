using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('#', n));
            for(int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', n / 2), new string('.', n - 2));
            }
            Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', n - 2));
           for(int i = n - 2; i >= 1; i--)
           {
               Console.WriteLine("{0}#{1}#{0}", new string('.', n * 2 - 1 - n - i), new string('.', 2 * i - 1));
           }
           Console.WriteLine("{0}#{0}", new string('.', n - 1));
        }
    }
}
