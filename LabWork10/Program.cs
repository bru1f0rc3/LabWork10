using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[6, 6];
            Random rand = new Random();

            for (int i = 0 ; i < 6; i++)
            {
                for (int j = 5 - i ; j >= 0 ; j--)
                {
                    n[i, j] = rand.Next(4, 10);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{n[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
