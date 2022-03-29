using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 9; i = i + 3)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
