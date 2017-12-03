using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TrainingGround
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = arr_temp.Select(s => Int32.Parse(s)).ToArray<Int32>();

        }
 

    }
}