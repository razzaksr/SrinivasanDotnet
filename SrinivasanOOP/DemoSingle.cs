using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    internal class DemoSingle:Mobius
    {
        public void display()
        {
            //Mobius mob = new Mobius();
            //int[][] arr=mob.getHai();
            int[][] arr = getHai();
            for (int row=0;row<arr.Length;row++)
            {
                Array.ForEach(arr[row], val => Console.WriteLine(val));
            }
        }
    }
    class Mobius
    {
        int[][] hai =  { 
            new int[]{ 4, 6, 12, 90, 13 }, 
            new int[]{ 45, 12 }, 
            new int[]{ 91, 67, 34, 23 } 
        };

        public int[][] getHai()
        {
            return hai;
        }
    }
}
