using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingGround
{
    class Triplets
    {
        private void T()
        {
            int[] tokens_a0 = new int[] { 5, 6, 7 };
            int[] tokens_b0 = new int[] { 3, 6, 10 };

            //string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            // string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }


        private int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            // Complete this function
            int countA = 0;
            int countB = 0;

            if (compare(a0, b0) == 1) { countA++; } else if (compare(a0, b0) == 2) { countB++; }
            if (compare(a1, b1) == 1) { countA++; } else if (compare(a1, b1) == 2) { countB++; }
            if (compare(a2, b2) == 1) { countA++; } else if (compare(a2, b2) == 2) { countB++; }


            int[] output = new int[2];

            output[0] = countA;
            output[1] = countB;

            return output;
        }

        private int compare(int n1, int n2)
        {
            if (n1 == n2)
            {
                return 0;
            }
            else if (n1 > n2)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        
    }
}
