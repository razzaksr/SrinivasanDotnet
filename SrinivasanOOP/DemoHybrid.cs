using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    internal class DemoHybrid
    {

    }

    class Spiral : DemoSingle
    {
        int[] yet = new int[11];
        public void spin()
        {
            int index = 0, row = 1, col = 1;
            for (;col>=0;col--,index++)
            {
                yet[index] = getHai()[row][col];
            }
            col++;row++;
            for (; col < getHai()[row].Length;col++,index++)
            {
                yet[index]=getHai()[row][col];
            }
            //col -= 2;
            row -= 2;
            for (; col >= 0; col--, index++)
            {
                yet[index] = getHai()[row][col];
            }
            Array.ForEach(yet,v=>Console.Write(v+" "));
            Console.WriteLine();
        }
    }

    class Linear : DemoSingle
    {
        int[] arrs = new int[11];
        public void arrange()
        {
            int index = 0;
            for (int row=0;row<getHai().Length;row++)
            {
                for (int col = 0; col < getHai()[row].Length;col++,index++)
                {
                    arrs[index]=getHai()[row][col];
                }
            }
            Array.ForEach(arrs, v => Console.WriteLine(v));
        }
    }
}
