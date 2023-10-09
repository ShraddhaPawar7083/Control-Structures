using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gross_Salary
{
    public class GrossSalary
    {
        public static void Main(string[] args)
        {
            double HRA, DA, Bs, Gs;

            Console.WriteLine("Enter the base salary: ");
            Bs = Single.Parse(Console.ReadLine());

            if(Bs <= 10000)
            {
                HRA = Bs * 0.2;
                DA = Bs * 0.8;
            }
            else if(Bs <= 20000)
            {
                HRA = Bs * 0.25;
                DA = Bs * 0.9;
            }
            else
            {
                HRA = Bs * 0.3;
                DA = Bs * 0.95;
            }
            Gs = Bs + DA + HRA;
            Console.WriteLine(" Gross salary is: " + Gs );
            Console.ReadLine();
        }
    }
}
