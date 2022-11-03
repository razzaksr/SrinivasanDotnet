using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class CreationArray
    {
        public void createArrOne()
        {
            String[] arr = { "Entity framework","hibernate","spring","react","jwt","axios","mui"};
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr[2]); //Read
            //Console.WriteLine(arr[arr.Length-1]);
            for (int index=2;index<arr.Length-2;index++)
            {
                Console.WriteLine(arr[index]);
            }
        }
        public void createArrTwo()
        {
            double[] arr= new double[10];
            int pos=0;
            while (pos<arr.Length)
            {
                arr[pos] = Convert.ToDouble(Console.ReadLine());
                pos++;
            }
            int index = 0;
            do
            {
                Console.WriteLine(arr[index]);
                index++;
            }while (index < arr.Length);
        }
    }
}