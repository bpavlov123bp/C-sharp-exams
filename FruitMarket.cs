using System;

namespace FruitMarketDemo
{
	class Program
	{
		public static void Main(string[] args)
		{
			string dayOfWeek = Console.ReadLine();
			double quant1 = double.Parse(Console.ReadLine());
			string prod1 = Console.ReadLine();
			double quant2 = double.Parse(Console.ReadLine());
			string prod2 = Console.ReadLine();
			double quant3 = double.Parse(Console.ReadLine());
			string prod3 = Console.ReadLine();
			
			double price = 0;
			bool isFruit = false;
			double totalPrice1 = 0;
			double totalPrice2 = 0;
			double totalPrice3 = 0;
			switch (prod1) {
				case "banana": 
					price = 1.80;
				isFruit = true;
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Tuesday")
				{
					price = price - price * 0.2;
				}
				if(dayOfWeek == "Thursday")
				{
					price = price - price * 0.3;
				}
				totalPrice1 = quant1 * price;
				
					break;
					case "cucumber": 
					price = 2.75;
				
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Wednesday")
				{
					price = price - price * 0.1;
				}
				
				totalPrice1 = quant1 * price;
				
					break;
					case "tomato": 
					price = 3.20;
				
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				
				if(dayOfWeek == "Wednesday")
				{
					price = price - price * 0.1;
				}
				
				totalPrice1 = quant1 * price;
				Console.WriteLine(totalPrice1);
					break;
					case "orange": 
					price = 1.60;
				isFruit = true;
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Tuesday")
				{
					price = price - price * 0.2;
				}
				
				totalPrice1 = quant1 * price;
				
					break;
					case "apple": 
					price = 0.86;
				isFruit = true;
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Tuesday")
				{
					price = price - price * 0.2;
				}
				
				totalPrice1 = quant1 * price;
				
					break;
				default:
					
					break;
			}
			switch (prod2) {
				case "banana": 
					price = 1.80;
				isFruit = true;
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Tuesday")
				{
					price = price - price * 0.2;
				}
				if(dayOfWeek == "Thursday")
				{
					price = price - price * 0.3;
				}
				totalPrice2 = quant2 * price;
				
					break;
					case "cucumber": 
					price = 2.75;
				
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Wednesday")
				{
					price = price - price * 0.1;
				}
				
				totalPrice2 = quant2 * price;
				
					break;
					case "tomato": 
					price = 3.20;
				
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				
				if(dayOfWeek == "Wednesday")
				{
					price = price - price * 0.1;
				}
				
				totalPrice2 = quant2 * price;
				
					break;
					case "orange": 
					price = 1.60;
				isFruit = true;
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Tuesday")
				{
					price = price - price * 0.2;
				}
				
				totalPrice2 = quant2 * price;
				
					break;
					case "apple": 
					price = 0.86;
				isFruit = true;
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Tuesday")
				{
					price = price - price * 0.2;
				}
				
				totalPrice2 = quant2 * price;
				
					break;
				default:
					
					break;
			}
			switch (prod3) {
				case "banana": 
					price = 1.80;
				isFruit = true;
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Tuesday")
				{
					price = price - price * 0.2;
				}
				if(dayOfWeek == "Thursday")
				{
					price = price - price * 0.3;
				}
				totalPrice3 = quant3 * price;
				
					break;
					case "cucumber": 
					price = 2.75;
				
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Wednesday")
			{
					price = price - price * 0.1;
				}
				
				totalPrice3 = quant3 * price;
				
					break;
					case "tomato": 
					price = 3.20;
				
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				
				if(dayOfWeek == "Wednesday")
				{
					price = price - price * 0.1;
				}
				
				totalPrice3 = quant3 * price;
				
					break;
					case "orange": 
					price = 1.60;
				isFruit = true;
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Tuesday")
				{
					price = price - price * 0.2;
				}
				
				totalPrice3 = quant3 * price;
				
					break;
					case "apple": 
					price = 0.86;
				isFruit = true;
				if(dayOfWeek == "Friday")
				{
					price = price - price * 0.1;
				}
				if(dayOfWeek == "Sunday")
				{
					price = price - price * 0.05;
				}
				if(dayOfWeek == "Tuesday")
				{
					price = price - price * 0.2;
				}
				
				totalPrice3 = quant3 * price;
				
					break;
				default:
					
					break;
			}
			double result = totalPrice1 + totalPrice2 + totalPrice3;
			Console.WriteLine("{0:f2}", result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}