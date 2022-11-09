using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    internal class DemoOverride:Mars
    {
        double[] quick = { 9.5,31.5,34.5,12.7,8.5,8.90,35.67,23.5,23.6,4.5};
        public double[] getQuick()
        {
            return quick;
        }
        public void search(double data)
        {
            for (int index=0;index<quick.Length; index++)
            {
                if (quick[index]==data)
                {
                    Console.WriteLine(data + " exists @ " + index);
                    return;
                }
            }
            Console.WriteLine(data + " doesn't exists in single dimension");
            base.search(data);
        }
    }
    class Mars
    {
        double[,] yet = { { 9.2,12.3},{5.6,24.6 },{6.7,3.2 },{9.2,5.6 } };
        public void search(double data)
        {
            for (int row=0;row<4;row++)
            {
                for (int col=0;col<2;col++)
                {
                    if (yet[row,col]==data)
                    {
                        Console.WriteLine(data + " exists @ row " + row + " and column " + col);
                        return;
                    }
                }
            }
            Console.WriteLine(data + " doesn't exists");
        }
    }
}
