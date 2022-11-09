using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    internal class DemoMultiple:Dyrect
    {

    }
    class Classic
    {
        String[] common = { "Evans","Doney","Johanson","Hiddleston","Pratt","Ruffalo","Holland","Xiakio" };
        public void filter(String userData)
        {
            for (int index=0;index<common.Length;index++)
            {
                if (common[index].StartsWith(userData))
                {
                    Console.WriteLine(common[index]);
                }
            }
        }
    }
    class Dyrect
    {
        int[] arr = new int[10];
        // 4500 1200 500 6000 2000 100 10900 800 500
        public void transaction()
        {
            for (int index=0;index<arr.Length;index++)
            {
                Console.WriteLine("Enter the current balance ");
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void statement()
        {
            int debits = 0;
            for (int index=1;index<arr.Length;index++)
            {
                if (arr[index] < arr[index-1])
                {
                    debits++;
                }
            }
            if (debits > 3)
            {
                Console.WriteLine("Total debits are " + debits + " but bank norms are 3");
                Console.WriteLine("20rs for each extra transaction beyond bank norms");
            }
        }
    }
}
