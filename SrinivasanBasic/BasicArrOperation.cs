using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class BasicArrOperation
    {
        public static void findMax()
        {
            char[] yet = { 'W','y','k','Z','R','a','m','s' };
            char max = yet[0];
            for (int pos=0;pos<yet.Length;pos++)
            {
                if (max < yet[pos])
                {
                    max = yet[pos];
                }
            }
            Console.WriteLine("Max value is " + max);
        }
        public static void findTwoMax(int[] arr)
        {
            int max1 = arr[0], max2 = arr[0];
            for (int index=0;index<arr.Length;index++)
            {
                if (max1 < arr[index])
                {
                    max2 = max1;
                    max1= arr[index];
                }
                if (max2 < arr[index]&&max1!=arr[index])
                {
                    max2 = arr[index];
                }
            }
            Console.WriteLine("Maximum 1 is " + max1 + " maximum 2 is " + max2);
        }
    }
}
