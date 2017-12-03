using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingGround
{
    class VeryBigSum
    {
        private void VBS()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = a_temp.Select(s => Int32.Parse(s)).ToArray<Int32>();
            }
        }

        static long aVeryBigSum(int n, long[] ar)
        {
            // Complete this function
            long output = 0;


            foreach (long item in ar)
            {
                var addvalue = item >= 0 ? item <= Math.Pow(10, 10) ? item : 0 : 0;
                output = output + addvalue;
            }

            return output;

        }
    }
}
