using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_Loss
{
    public class ProfitLoss
    {
        public static void Main(string[] args)
        {
            int cprice, sprice, amt;

            Console.Write("Enter Cost Price: ");
            cprice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Selling Price: ");
            sprice = Convert.ToInt32(Console.ReadLine());

            if (sprice > cprice)
            {
                amt = sprice - cprice;
                Console.Write(amt + "\nYou got a profit amount : \n");
            }
            else if (cprice > sprice)
            {
                amt = cprice - sprice;
                Console.Write(amt + "\nYou got a loss of amount : \n");
            }
            else
            {
                Console.Write("\nYou can't get profit or loss.\n");
            }
        }
    }
}
