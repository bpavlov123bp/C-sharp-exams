using System;

namespace Sunlight
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int dotsOut = 1;
			int dotsIn = (n * 3) / 2 - 2;
			Console.WriteLine("{0}*{0}", new String('.', n * 3 / 2));
			for(int i = 0; i < n - 1; i++)
			{
				Console.WriteLine("{0}*{1}*{1}*{0}", new String('.',dotsOut), new String('.', dotsIn));
				dotsOut++;
				dotsIn--;
			}
			for(int q =1; q <= n / 2; q++)
			{
				Console.WriteLine("{0}{1}{0}", new String('.', n), new String('*', n));
			}
			Console.WriteLine("{0}", new String('*', n * 3));
			for(int q =1; q <= n / 2; q++)
			{
				Console.WriteLine("{0}{1}{0}", new String('.', n), new String('*', n));
			}
			for(int i = 0; i < n - 1; i++)
			{
				dotsOut--;
				dotsIn++;
				Console.WriteLine("{0}*{1}*{1}*{0}", new String('.',dotsOut), new String('.', dotsIn));
			}
			Console.WriteLine("{0}*{0}", new String('.', n * 3 / 2));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
