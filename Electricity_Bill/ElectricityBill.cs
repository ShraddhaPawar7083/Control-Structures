using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill
{
    public class ElectricityBill
    {
        public static void Main(string[] args)
        {
            double unit, bill;

            Console.WriteLine("Enter electricity unit: ");
            unit = Convert.ToDouble(Console.ReadLine());

            if (unit <= 50)
            {
                bill = unit * 2.0;
            }
            else if (unit <= 100)
            {
                bill = 100 + (unit - 50) * 2.5;
            }
            else
            {
                bill = 100 + (unit - 100) * 5.25;
            }
            Console.WriteLine("Electricity bill is: " + bill);
            Console.ReadLine();
        }
    }
}
