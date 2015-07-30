using System;
using System.Collections.Generic;
namespace EncryptTheMessage
{
	class Program
	{
		public static void Main(string[] args)
		{
			string input;
			List<string> message = new List<string>();
			do
			{
				input = Console.ReadLine();
			}while(input.ToUpper() != "START");
			input = Console.ReadLine();
			while(input.ToUpper() != "END")
			{
				if(input != string.Empty)
				{
					string encryptedMessage = "";
					for(int i = 0; i < input.Length; i++)
					{
						if((input[i] >= 'A' && input[i] <= 'M') || (input[i] >= 'a' && input[i] <= 'm'))
						{
							encryptedMessage += (char)(input[i] + 13);
						}
						else if((input[i] >= 'N' && input[i] <= 'Z') || (input[i] >= 'n' && input[i] <= 'z'))
						{
							encryptedMessage += (char)(input[i] - 13);
						}
						else if(input[i] >= '0' && input[i] <= '9')
						{
							encryptedMessage += input[i];
						}
						else
						{
							switch(input[i])
							{
								case ' ': 
									encryptedMessage += '+';
									break;
								case ',':
									encryptedMessage += '%';
									break;
								case '.':
									encryptedMessage += '&';
									break;
								case '?':
									encryptedMessage += '#';
									break;
								case '!':
									encryptedMessage += '$';
									break;
							}
						}
					}
					char[] arr = encryptedMessage.ToCharArray();
					Array.Reverse(arr);
					encryptedMessage = new string(arr);
					message.Add(encryptedMessage);
				}
				input = Console.ReadLine();
			}
			if(message.Count != 0)
			{
				Console.WriteLine("Total number of messages: {0}", message.Count);
				foreach (var msg in message) {
					Console.WriteLine(msg);
				}
			}
			else
			{
				Console.WriteLine("No messages sent.");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
