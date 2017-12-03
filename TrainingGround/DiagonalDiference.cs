using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingGround
{
    class DiagonalDiference
    {
        private void DD()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = a_temp.Select(s => Int32.Parse(s)).ToArray<Int32>();
            }

            Console.WriteLine();

            int sumA = 0;
            int sumB = 0;

            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (x == i)
                    {
                        sumA = sumA + a[x][i];
                        Console.Write("value row X" + a[x][i]);
                        Console.WriteLine();
                    }

                    if ((x + i == n - 1))
                    {
                        sumB = sumB + a[x][i];
                        Console.Write("value row Y" + a[x][i]);
                        Console.WriteLine();
                    }
                }
            }

            var res = sumA - sumB;

            Console.Write(Math.Abs(res));
            Console.ReadKey();
        }
    }
}
