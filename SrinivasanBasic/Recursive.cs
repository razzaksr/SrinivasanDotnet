using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class Recursive
    {
        public void seekSome()
        {
            Console.WriteLine("Seeking Authority");
            grant();
        }
        public void grant()
        {
            Console.WriteLine("Granting authority from HR to Team Lead");
        }
        public void retrospective()
        {
            Console.WriteLine("Scrum meeting happens at end of the sprint");
            retrospective();
        }
        public void range(int start,int end)
        {
            if (start <= end)
            {
                Console.WriteLine("Welcome to the hell "+start);
                start++;
                range(start, end);
            }
            else
                return;
            
        }
    }
}
