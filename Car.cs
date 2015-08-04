using System;

namespace Cars
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int width = 3 * n;
			int height = width / (2 - 1);
			Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
			for(int i = 1; i <= n / 2 - 1; i++)
			{
				Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string('.', (n - 2) + (2 * i)));
			}
			Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n * 2 - 2));
			for(int i = 1; i <= n / 2 - 2; i++)
			{
				Console.WriteLine("*{0}*", new string('.', width - 2));
			}
			Console.WriteLine("{0}", new string('*', width));
			for(int i = 1; i <= n / 2 - 2; i++)
			{
				Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', n / 2), new string('.', n / 2 - 1), new string('.', n - 2));
			}
			Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('*', n / 2 + 1), new string('.', n - 2));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
