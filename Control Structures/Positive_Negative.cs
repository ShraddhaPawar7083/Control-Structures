using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Structures
{
    public class Positive_Negative
    {
        public static void Main(string[] args)
        {
            int num;
           
            Console.Write("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)

                Console.WriteLine(num + " is a zero number.\n");
            else if (num < 0)
                Console.WriteLine(num + " is a negative number. \n");
            else if (num > 0)
                Console.WriteLine(num + " is a positive number. \n");
        }
    }
}
