using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max
{
    public class MinMax
    {
        public static void Main(String [] args)
        {
            int a, b;

            Console.WriteLine("Enter First Numbers : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Numbers : ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is the Maximum Number", a);
            }
            else
            {
                Console.WriteLine("{0} is the Mximum Number ", b);
            }
            Console.ReadLine();
        }
    }
}
