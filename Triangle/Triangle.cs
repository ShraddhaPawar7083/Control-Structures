using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public static void Main(string[] args)
        {
            {
                int s1, s2, s3;

                Console.Write("Enter first side of triangle: ");
                s1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second side of triangle: ");
                s2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter third side of triangle: ");
                s3 = Convert.ToInt32(Console.ReadLine());

                if (s1 == s2 && s2 == s3)
                {
                    Console.Write("This is an equilateral triangle.\n");
                }
                else if (s1 == s2 || s1 == s3 || s2 == s3)
                {
                    Console.Write("This is an isosceles triangle.\n");
                }
                else
                {
                    Console.Write("This is a scalene triangle.\n");
                }
            }
        }
    }
}
