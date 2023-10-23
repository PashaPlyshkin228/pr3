using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak3matrix
{
    public static class Mas
    {
        public static int[,] GenerateMas(int m, int n)
        {
            Random random = new Random();
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(0, 5);
                }
            }
            return matrix;
        }
    }
}
