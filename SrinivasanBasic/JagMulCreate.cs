using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class JagMulCreate
    {
        public void born()
        {
            double[,] hai = { {3.4,9.1,7.8 },{89.2,4.5,2.5 },{ 9.2,4.6,12.4},{ 4.5,8.9,5.9} };
            String[][] jj = { new String[] { "Vikram","Santhanam","Ramakrishnan" },
                            new String[]{"Dilli","gomathi" },
                            new String[]{ "bejoy","kavin","victor"} };
            for (int row=0; row < 4;row++)
            {
                for (int col = 0; col < 3;col++)
                {
                    Console.Write(hai[row, col]+" ");
                }
                Console.WriteLine();
            }

            for (int row=0;row<jj.Length;row++)
            {
                for (int col = 0; col < jj[row].Length;col++)
                {
                    Console.Write(jj[row][col]+" ");
                }
                Console.WriteLine();
            }
        }

        
    }
}
