using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class Blocks
    {
        public float cmToInch(int centi)
        {
            return (float)(centi * 0.393);
        }
        public void dollarToRupees(int dollar)
        {
            Console.WriteLine(dollar * 79.8);
        }
    }
}
