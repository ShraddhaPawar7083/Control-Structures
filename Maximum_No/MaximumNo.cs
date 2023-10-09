using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_No
{
    public class MaximumNo
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter first number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The first Number is the maximum. \n\n");
                }
                else
                {
                    Console.Write("The third Number is the maximum. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The second Number is the maximum \n\n");
            else
                Console.Write("The third Number is the maximum \n\n");
        }

    }
}
