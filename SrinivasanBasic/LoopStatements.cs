using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class LoopStatements
    {
        public void demoDoWhile()
        {
            /*
            int number = 101;
            do
            {
                if (number % 2 != 0)
                    Console.WriteLine(number);
                number++;
            } while (number <= 100);
            */
        }
        public void demoWhile()
        {
            /*
            int num = 1;// init
            while (num <= 10)// cond
            {
                Console.WriteLine(num);
                num++;//iter
            }
            */
            /*
            Console.WriteLine("enter the number to check prime ");
            int number=Convert.ToInt32(Console.ReadLine());
            int start = 2;
            while (start<=number)
            {
                if (start == 2 || start == 3 || start == 5 || start == 7 || start % 2 != 0 &&
                start % 3 != 0 && start % 5 != 0 && start % 7 != 0)
                {
                    Console.WriteLine(start + " is prime");
                }
                start++;
            }
            */
            /*
            Console.WriteLine("enter the start to check prime ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the end to check prime ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (start <= number)
            {
                if (start == 2 || start == 3 || start == 5 || start == 7 || start % 2 != 0 &&
                start % 3 != 0 && start % 5 != 0 && start % 7 != 0)
                {
                    Console.WriteLine(start + " is prime");
                }
                start++;
            }
            */
            int num = 2;
            while (num<=100)
            {
                Console.WriteLine(num);
                num += 2;
            }
        }
    }
}
