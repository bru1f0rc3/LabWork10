using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[6, 6];
            int total = 0;
            int average = 0;
            Random rand = new Random();

            for (int i = 2; i <= 5; i++) // int.Parse(Console.ReadLine());
            {
                for (int j = 5 - i; j <= i; j++)
                {
                    n[j, 5 - i] = rand.Next(-10, 40); // -10 до 39
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{n[i, j]}\t");
                }
                Console.WriteLine();
            }

            for (int i = 2; i <= 5; i++) // Первое задание
            {
                for (int j = 5 - i; j <= i; j++)
                {
                    if (n[j, 5 - i] > 0)
                    {
                        average += n[j, 5 - i];
                    }
                }
            }

            Console.WriteLine($"Среднее арифметическое: {average / 12}");

            for (int i = 2; i <= 5; i++) // Второе задание
            {
                for (int j = 5 - i; j <= i; j++)
                {
                    if (n[j, 5 - i] > 0)
                    {
                        total++;
                    }
                }
            }

            int[] X = new int[total];
            int count = 0;
            for (int i = 2; i <= 5; i++)
            {
                for (int j = 5 - i; j <= i; j++)
                {
                    if (n[j, 5 - i] > 0)
                    {
                        X[count] = n[j, 5 - i];
                        count++;
                    }
                }
            }

            int[] P = new int[12];
            int multiplications = 1;
            int multiplications_count = 0;
            for (int i = 2; i <= 5; i++) // Третие задание
            {
                for (int j = 5 - i; j <= i; j++)
                {
                    multiplications *= n[j, 5 - i]; 
                    P[multiplications_count] = multiplications;
                    multiplications_count++;
                }

            }

            // Четвертое задание
            int Min = n[0, 0];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6 ; j++)
                {
                    if (n[i,j] < Min)
                    {
                        Min = n[i,j];
                    }
                }
            }

            int Min_count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (n[i, j] == Min)
                    {
                        Min_count++;
                    }
                }
            }
            Console.WriteLine($"X={string.Join(",", X)}");
            Console.WriteLine($"P={string.Join(",", P)}");
            Console.WriteLine($"Количество элементов в левой половине: {Min_count}\nМинимальный элемент всей матрицы: {Min}");
        }
    }
}
