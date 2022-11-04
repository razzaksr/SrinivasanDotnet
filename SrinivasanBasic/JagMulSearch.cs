using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class JagMulSearch
    {
        public void linear(out int row,out int col, String userWish)
        {
            String[][] jj = { new String[] { "Vikram","Santhanam","Ramakrishnan" },
                            new String[]{"Dilli","gomathi" },
                            new String[]{ "bejoy","kavin","victor"} };

            for (int floor=0;floor<jj.Length;floor++)
            {
                for (int house = 0; house < jj[floor].Length;house++)
                {
                    if (jj[floor][house].Equals(userWish))
                    {
                        row = floor;
                        col = house;
                        return;
                    }
                }
            }
            row = -1;col = -1;
            return;
        }
    }
}
