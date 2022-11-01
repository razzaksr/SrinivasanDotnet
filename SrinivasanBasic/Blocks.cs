using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class Blocks
    {
        public static int swaps(out int spring,out int jpa)
        {
            int calm = 90, palm=20;
            spring = calm;
            jpa = palm;
            return 10000;
        }
        public int hello()
        {
            return 10;
        }
        public void just(ref int react,ref int axios)
        {
            Console.WriteLine("Recieved" + react + " " + axios);
            react ^= axios;
            axios ^= react;
            react ^= axios;
            Console.WriteLine("Changed" + react + " " + axios);
        }
        public void just(int one,int two)
        {
            Console.WriteLine("Recieved"+ one + " " +two);
            one ^= two;
            two ^= one;
            one ^= two;
            Console.WriteLine("Changed" + one + " " + two);
        }
        public int otp()
        {
            Random random = new Random();
            String tmp = "";
            for (int num=1;num<=6;num++)
            {
                tmp+=random.Next(10);
            }
            int pin = Convert.ToInt32(tmp);
            //Console.WriteLine(pin);
            return pin;
        }
        public void access()
        {
            int size=Convert.ToInt32(Console.ReadLine());
            int limit = size * 2 - 1;
            for (int row=size;row>=1;row--)
            {
                for (int space=size;space>row;space--)
                {
                    Console.Write(" ");
                }
                for (int data=1;data<=limit;data++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                limit -= 2;
            }
        }
        public void eric(int sizeA, int sizeB)
        {
            for (int axe=1; axe<=sizeA; axe++)
            {
                for (int bot=1;bot<=sizeB;bot++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
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
