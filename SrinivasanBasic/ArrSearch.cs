using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class ArrSearch
    {
        public static int linear(String userWish)
        {
            String[] arr = { "Robert","Evans","Downey","Johanson","Pratt","Brad","Hemsworth" };
            for (int index=0;index<arr.Length;index++)
            {
                if (userWish.Equals(arr[index]))
                {
                    return index;
                }
            }
            return -1;
        }


        public double[] hey = { 4.5,9.1,12.5,15.6,19.6,21.6,56.7,88.2,100.5};
        public int binary(int start,int end,double userWish)
        {
            if (start<=end)
            {
                int mid = start + (end - start) / 2;
                if (hey[mid] == userWish)
                    return mid;
                else if (hey[mid] > userWish)
                    return binary(start,mid-1,userWish);
                else
                    return binary(mid+1,end,userWish);
            }
            return -1;
        }
    }
}
