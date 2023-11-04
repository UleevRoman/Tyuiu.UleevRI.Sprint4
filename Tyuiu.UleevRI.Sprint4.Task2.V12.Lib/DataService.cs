using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UleevRI.Sprint4.Task2.V12.Lib
{
    public class DataService : ISprint4Task2V12
    {
        public int Calculate(int[] array)
        {
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) m += array[i];
            }
            return m;
        }
    }
}
