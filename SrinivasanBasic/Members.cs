using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SrinivasanBasic
{
    internal class Members
    {
        public static void telSome()
        {
            Members me = new Members();
            Console.WriteLine(me.max);
        }
        public int max;// class level/ global member
        public void doSome()
        {
            int maxi = 34;
            Console.WriteLine(maxi);
            //Console.WriteLine(max);
            max += 10;
            Console.WriteLine(max+" @ doSome");
        }
        public void actSome()
        {
            //Console.WriteLine(maxi);
            Console.WriteLine(max + " @ actSome");
        }
    }
}
