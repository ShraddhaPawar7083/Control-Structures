using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public class Character
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + " Is an Alphabet");
            }
            else if (ch >= 'a' && ch <= 'z') 
            {
                Console.WriteLine(ch + " Is an Alphabet");
            }
            else if(ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + " Is an Disit");
            }
            else
            {
                Console.WriteLine(ch + " Is an Special Character");
            }
            Console.ReadLine();
        }
    }
}
