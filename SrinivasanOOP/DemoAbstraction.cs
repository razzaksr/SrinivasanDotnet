using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    class Collab : DemoAbstraction
    {
        public override void sink()
        {
            Console.WriteLine("Overriden from abstract class");
        }
    }
    internal abstract class DemoAbstraction:DemoOverride
    {
        double[,] our = new double[2, 5];

        public abstract void sink();// abstract method
        public void transfer()// non abstract method
        {
            int index = 0;
            for (int row=0;row<2;row++)
            {
                for (int col=0;col<5;col++,index++)
                {
                    our[row, col] = getQuick()[index];
                    Console.Write(our[row, col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    interface Zeta
    {
        public void checkSome();// abstract method
    }
    class Sigma
    {
        //public void hello();// abstract method
        public void hello() // non abstract method
        {

        }
    }
}
