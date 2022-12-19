using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func
{
    internal class Solution
    {
        private int x;

        public int[,] matrix;

        public Solution(int x, int[,] matrix)
        {
            this.x = x;
            this.matrix = matrix;
        }

        Random r = new Random();
        public int GetSolution()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrix[i, j] = r.Next(1, 10);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (i != j) sum += matrix[i, j];
                }
            }
            return sum;
        }

    }
}
