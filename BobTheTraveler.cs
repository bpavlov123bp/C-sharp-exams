using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobTraveller
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double contractMonth = double.Parse(Console.ReadLine());
            double familyMonth = double.Parse(Console.ReadLine());
            double travelContractMonth = 12 * contractMonth;
            double travelFamylyMonth = 2 * 2 * familyMonth;
            double travelNormalMonths = 12 * (12 - contractMonth - familyMonth) * 3 / 5;
            double travelLeapYear = 0;
            double totalTravels = 0;
            if(year == "leap")
            {
                travelLeapYear = (travelContractMonth + travelFamylyMonth + travelNormalMonths) * 5 / 100;
                totalTravels = Math.Floor(travelContractMonth + travelFamylyMonth + travelNormalMonths + travelLeapYear);
                Console.WriteLine(totalTravels);
            }
            else if(year == "normal")
            {
                totalTravels = Math.Floor(travelContractMonth + travelFamylyMonth + travelNormalMonths);
                Console.WriteLine(totalTravels);
            }
        }
    }
}
