using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmar_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fizz buzz
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }

            }

            //Reverse of string
            Console.WriteLine("Enter Input String");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            char[] reverseChar = new char[input.Length];

            int len = chars.Length;

            int temp = 0;
            for (int i = len; i <= chars.Length; i--)
            {
                if (i > 0)
                {
                    reverseChar[temp] = chars[i - 1];
                    temp += 1;
                }
                if (i == 0)
                {
                    break;
                }

            }
            string res = "";
            foreach (char c in reverseChar)
            {
                res += c;
            }
            Console.WriteLine("Reverse Of a string is:-" + res);

            Console.ReadLine();
        }
    }
}
