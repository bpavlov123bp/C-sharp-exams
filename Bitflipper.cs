using System;

namespace BitFlipper
{
	class Program
	{
		public static void Main(string[] args)
		{
			ulong number = ulong.Parse(Console.ReadLine());
			int index = 0;
			string input = Convert.ToString((long)number, 2).PadLeft(64, '0');
			char[] arr = input.ToCharArray();
			for(int i = 0; i < 62; i++)
			{
				if(arr[i + index] == arr[i + 1 +index] && arr[i + index] == arr[i + 2 + index])
				{
				if(arr[i + index] == '0')
				{
					arr[i + index] = '1';
					arr[i + 1 + index] = '1';
					arr[i + 2 + index] = '1';
				}
				else
				{
					arr[i + index] = '0';
					arr[i + 1 + index] = '0';
					arr[i + 2 + index] = '0';
				}
				index = index + 2;
				if(i + index > 60)
				{
					break;
				}
			}
		}
			Console.WriteLine(Convert.ToUInt64(string.Join("", arr), 2));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
