using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа работы массивов.\nВведите размерность массивов:\nM = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            int[,] c = new int[m, n];
            int[,] d = new int[m, n];
            Random rnd = new Random();
            int det = 0;
            // Ввод матриц
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = rnd.Next(-10, 10);
                    d[i, j] = rnd.Next(-10, 10);
                }
            }
            // вывод матриц
            Console.WriteLine("Массив c:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив d:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(d[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Нахождение определителя
            for (int i = 0; i < 3; i++)
            {
                det = det + (c[0, i] * (c[1, (i + 1) % 3] * c[2, (i + 2) % 3] - c[1, (i + 2) % 3] * c[2, (i + 1) % 3]));
            }
            Console.Write("Определитель:" + det + "\n"); // вывод det
            // Сумма матриц
            int[,] sum = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum[i, j] = c[i, j] + d[i, j];
                }
            }
            // Вывод суммы матриц
            Console.WriteLine("Вывод произведения матриц:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Произведение матриц
            int[,] mult = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mult[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        mult[i, j] += c[i, k] * d[k, j];
                    }
                }
            }
            // вывод матрицы произведения
            Console.WriteLine("Матрица произведения матриц: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mult[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
