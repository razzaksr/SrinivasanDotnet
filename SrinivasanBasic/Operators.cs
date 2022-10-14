﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class Operators
    {
        public void precedence()
        {
            // Bracket Of(Unary) Divide Multiply Addition Subtraction
            //double sink = 8.9;int water = 11; double result = 0;
            //result = (sink--) + (water += 5) - (sink /= 2);
            //Console.WriteLine(result);

            short say = 34;char tick = 'Q';int result = 0;
            //result = (++tick) - (say -= 10) + (tick /=(char) 2);
            // 82 - 24 + 41 >> 58+41>> 99

            result = (say*=2)+(tick--)/(say-=9);
            // 68 + 81 / 59 >> 68+1
            Console.WriteLine(result);
        }
        public void shortHand()
        {
            // assignment operator : += -= *= /= %=
            // syntax: var1+=var2>> var1 = var1+var2
            // first obj/var should be same as storing var/obj
            // var2=var1+var2;

            // char -127 to 128

            char hai = 'R';int yet = 99;
            Console.WriteLine("Character " + hai + " Integer " + yet);
            hai *=(char) yet;
            yet = hai / yet;
            hai /= (char) yet;
            Console.WriteLine("Character " + hai + " Integer " + yet);
        }
        public void unary()
        {
            // ++   >> increment + 1
            // --   >> decrement - 1
            // pre  >> symbol variable      >> result in same spot
            // post >> variable symbol      >> result in next spot(usage of same variable in next time)

            double say = 78.4;char pickle = 'w';
            Console.WriteLine(say+" "+pickle);
            Console.WriteLine(--say + " " + pickle);
            Console.WriteLine(say + " " + pickle++);
            Console.WriteLine(say + " " + pickle);
            Console.WriteLine(say-- + " " + pickle);
            Console.WriteLine(say + " " + pickle);
            Console.WriteLine(say + " " + ++pickle);

        }
        public void arithmetic()
        {
            char hey = 'E';
            Console.WriteLine((char)(hey+3)); 
            //double hi = 4.5, where = 9.2, third=0;
            double hi = 4.5; 
            int where = 9;
            Console.WriteLine("Hi value is "+hi+" Where value is "+where);

            // swap using third variable
            //third = hi;
            //hi = where;
            //where = third;

            // swap using + -
            //hi = hi + where;// 13.7
            //where = hi - where;// 4.5
            //hi= hi - where;//9.2

            // swap using * /
            //hi = hi * where;// 41.4
            //where = hi / where;// 4.5
            //hi = hi / where;// 9.2

            hi=hi+where;//40.5// 13.5
            where =(int) hi - where;//4// 4
            hi = hi - where;// 10.// 9.5

            Console.WriteLine("Hi value is " + hi + " Where value is " + where);

            Console.WriteLine(4 % 3);

            // payslip generate
            double ctc = 450000.92;
            double month = ctc / 12;
            Console.WriteLine(month);
            double net = month + (month * 7) / 100;
            Console.WriteLine(net);
            double takeHome = net - (net * 10) / 100;
            Console.WriteLine(takeHome); 
        }
    }
}