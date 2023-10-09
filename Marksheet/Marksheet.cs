using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet
{
    public class Marksheet
    {
        public static void Main(string[] args)
        {
            int C, CPP, Java, Dotnet, Python;
            float total, percentage;

            Console.WriteLine("Enter the marks of C: ");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of Cpp: ");
            CPP = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of Java: ");
            Java = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of Dotnet: ");
            Dotnet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of Python: ");
            Python = Convert.ToInt32(Console.ReadLine());

            total = C + CPP + Java + Dotnet + Python;

            percentage = total / 5.0f;

            Console.WriteLine("The sum of five subject: " + total);
            Console.WriteLine("Percentage is: " + percentage);

            if (percentage < 40)
            {
                Console.WriteLine("Grade is F");
            }
            else if (percentage >= 40  && percentage <= 59)
            {
                Console.WriteLine("Grade is E");
            }
            else if (percentage >= 60 && percentage <= 69)
            {
                Console.WriteLine("Grade is D");
            }
            else if (percentage >= 70 && percentage <= 79)
            {
                Console.WriteLine("Grade is C");
            }
            else if (percentage >= 80 && percentage <= 89)
            {
                Console.WriteLine("Grade is B");
            }
            else if (percentage >= 90)
            {
                Console.WriteLine("Grade is A");
            }
            Console.ReadLine();
        }
    }
}
