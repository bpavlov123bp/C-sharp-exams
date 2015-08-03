using System;

namespace BookOrders
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numberOfOrders = int.Parse(Console.ReadLine());
			double discount = new double();
			int totalBooks = 0;
			 double totalPriceOfBooks = 0;
			for(int i = 0; i < numberOfOrders; i++)
			{
				int numberOfPackets = int.Parse(Console.ReadLine());
				int booksPerPacket = int.Parse(Console.ReadLine());
				double bookPrice = double.Parse(Console.ReadLine());
				totalBooks += numberOfPackets * booksPerPacket;
				if(numberOfPackets < 10)
				{
					discount = 1;
				}
				else if(numberOfPackets >= 10 && numberOfPackets <= 109)
				{
					discount = (100 - (numberOfPackets / 10 + 4)) / 100.00;
				}
				else
				{
					discount = (100 - 15) / 100.00;
				}
				totalPriceOfBooks += numberOfPackets * booksPerPacket * bookPrice * discount;
			}
			Console.WriteLine(totalBooks);
			Console.WriteLine("{0:F2}", totalPriceOfBooks);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
