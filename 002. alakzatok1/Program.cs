using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.alakzatok1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 11; i++)
            {
                Console.Write("o");
            }

            Console.ReadKey();
        }
    }
}
