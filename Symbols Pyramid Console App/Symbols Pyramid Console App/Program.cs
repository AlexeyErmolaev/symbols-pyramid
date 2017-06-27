using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbols_Pyramid_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j, s = 10, t = 1, k;
            Console.WriteLine("Input k:");
            k = Convert.ToInt32(Console.ReadLine());

            while (i <= k)
            {
                j = 1;
                while (j <= s)
                {
                    Console.Write(" ");
                    j++;
                }
                j = 1;
                while (j <= t)
                {
                    Console.Write("#");
                    j++;
                }
                Console.WriteLine();
                s--;
                t += 2;
                i++;
            }
            Console.ReadLine();
        }
    }
}
