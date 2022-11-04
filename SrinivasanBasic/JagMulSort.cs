using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class JagMulSort
    {
        public void bubble(double[,] say)
        {
            for (int row=0;row<4;row++)
            {
                for (int times = 0; times < 3 - 1; times++)
                {
                    for (int bub = 0; bub < 3 - 1 - times; bub++)
                    {
                        if (say[row,bub] > say[row,bub + 1])
                        {
                            say[row,bub] *= say[row,bub + 1];
                            say[row,bub + 1] = say[row,bub] / say[row,bub + 1];
                            say[row,bub] /= say[row,bub + 1];
                        }
                    }
                }
            }
            view(say);
        }

        public void view(double[,] arr)
        {
            for (int row=0;row<4;row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    Console.Write(arr[row, col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
