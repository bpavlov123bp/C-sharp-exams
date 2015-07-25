using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInformation
{
    class AccountInformation
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int clientId = int.Parse(Console.ReadLine());
            double totalAccountBalance = double.Parse(Console.ReadLine());
            if(totalAccountBalance >= 0)
            {
                Console.WriteLine("Hello, {0} {1}", firstName, lastName);
                Console.WriteLine("Client id: {0}", clientId);
                Console.WriteLine("Total balance: {0:f2}", totalAccountBalance);
                Console.WriteLine("Active: yes");
            }
            else
            {
                Console.WriteLine("Hello, {0} {1}", firstName, lastName);
                Console.WriteLine("Client id: {0}", clientId);
                Console.WriteLine("Total balance: {0:f2}", totalAccountBalance);
                Console.WriteLine("Active: no");
            }
        }
    }
}
