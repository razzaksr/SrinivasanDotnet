using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class ArrSort
    {
        public void view(int[] arr)
        {
            Array.ForEach(arr, q => Console.WriteLine(q));
        }
        public void view(double[] arr)
        {
            Array.ForEach(arr,q=>Console.WriteLine(q));
        }
        public void bubble(params int[] say)
        {
            for (int times=0;times<say.Length-1;times++)
            {
                for (int bub=0;bub<say.Length-1-times;bub++)
                {
                    if (say[bub] > say[bub+1])
                    {
                        say[bub] ^= say[bub + 1];
                        say[bub+1] ^= say[bub];
                        say[bub] ^= say[bub + 1];
                    }
                }
            }
            view(say);
        }
        public void selection(params double[] kind)
        {
            for (int select=0;select<kind.Length-1;select++)
            {
                for (int comp=select+1;comp<kind.Length;comp++)
                {
                    if (kind[select] < kind[comp])
                    {
                        kind[select] += kind[comp];
                        kind[comp] = kind[select] - kind[comp];
                        kind[select] -= kind[comp];
                    }
                }
            }

            view(kind);
        }
    }
}
