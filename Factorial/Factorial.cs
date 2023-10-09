using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Factorial
    {
        public static void Main(string[] args)
        {
            int i, f = 1, a;

            Console.Write("Entert the number : ");
            a = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= a; i++)

                f = f * i;

            Console.Write("The Factorial of " + a + " is:\n" + f);
        }
    }
}
