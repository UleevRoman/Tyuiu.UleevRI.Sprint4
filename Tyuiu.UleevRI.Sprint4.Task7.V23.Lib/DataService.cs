using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UleevRI.Sprint4.Task7.V23.Lib
{
    public class DataService : ISprint4Task7V23
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) matrix[i, j] = int.Parse(value.Substring(i * m + j, 1));
            }
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0) res += 1;
                }
            }
            return res;
        }
    }
}
