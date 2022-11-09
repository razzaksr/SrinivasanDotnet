using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    internal class DemoInterface : Alpha, Beta
    {
        public void floyd()
        {
            for(int row = 10; row >=1; row--)
            {
                for (int space=10;space>row;space--)
                {
                    Console.Write(" ");
                }
                for (int data=1;data<=row;data++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        public void hai()
        {
            Console.WriteLine("Overridden from Alpha");
        }
    }
    interface Alpha
    {
        public void hai();// abstract method
    }
    interface Beta
    {
        public void floyd();
    }
}
