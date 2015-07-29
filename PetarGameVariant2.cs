using System;
using System.Linq;
namespace PetarGame
{
	class Program
	{
		public static void Main(string[] args)
		{
			ulong startNumber = ulong.Parse(Console.ReadLine());
			ulong endNumber = ulong.Parse(Console.ReadLine());
			string replaceDigit = Console.ReadLine();
			ulong sum = 0;
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
			string str = sum.ToString();
			string digit;
			if(sum % 2 == 0)
			{
				digit = str[0].ToString();
			}
			else
			{
				digit = str[str.Length - 1].ToString();
			}
			str = str.Replace(digit, replaceDigit);
			Console.WriteLine(str);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
