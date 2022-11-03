using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class ArrayCall
    {
        public void dyn()
        {
            modification(34F, 56F, 9.2F, 88.4F, 3.4F);
        }
        public void modification(params float[] yet)
        {
            for (int index = 0; index < yet.Length; index++)
            {
                if (yet[index] > 10.5)
                {
                    yet[index] -= (float)(yet[index] * 0.050);
                }
            }
            display(yet);
        }
        public void display(float[] arr)
        {
            foreach (float v in arr)
            {
                Console.WriteLine(v);
            }
        }
        public void update()
        {
            float[] arr = { 9.2F,0.56F,34.8F,12.6F,8.8F,2F};
            //arr[3] = 34.5F;

            display(arr);   
            modification(arr);
            display(arr);
            /*
            for (int index=0;index<arr.Length;index++)
            {
                if (arr[index] > 10.5) 
                {
                    arr[index] -= (float)(arr[index] * 0.050);
                }
            }
            */

            /*
            foreach (float v in arr)
            {
                Console.WriteLine(v);
            }
            */
        }
    }
}
