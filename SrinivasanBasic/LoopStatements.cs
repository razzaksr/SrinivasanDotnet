using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class LoopStatements
    {
        public void demoPatterns()
        {
            // upper pyramid
            int limit = 1;
            int userWish = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= userWish; row++)
            {
                for (int space = userWish; space > row; space--)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= limit; col++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
                limit += 2;
            }
            /*
            // upper pascal triangle
            int userWish = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= userWish; row++)
            {
                for (int space = userWish; space > row; space--)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
            */
            /*
            // right upper floyd
            int userWish = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= userWish; row++)
            {
                for (int space=userWish;space>row;space--)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
            */
            /*
            // left upper floyd
            int userWish = Convert.ToInt32(Console.ReadLine());
            for (int row=1;row<=userWish;row++)
            {
                for (int col=1;col<=row;col++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
            */
            /*
            // perfect square
            int row = 1, wish=0, number=1;
            wish=Convert.ToInt32(Console.ReadLine());
            do
            {
                int col = 1;
                do
                {
                    //Console.Write(number);
                    //Console.Write(row);
                    //Console.Write(col);
                    Console.Write("$");
                    col++;
                    number++;
                } while (col <= wish);
                Console.WriteLine();
                row++;
            } while (row <= wish);
            */
        }
        public void demoNested()
        {
            int userPay = 0, row=1, seat=1;
            String chart = "";
            while (row<=5)
            {
                seat = 1;
                while (seat<=4)
                {
                    Console.WriteLine("Enter the amount to book tocket");
                    userPay=Convert.ToInt32(Console.ReadLine());
                    if (userPay >= 250)
                    {
                        Console.WriteLine("Seat " + seat + " booked @ row " + row);
                        chart += "$";
                    }
                    else
                    {
                        Console.WriteLine("Seat " + seat + " hasn't booked @ row " + row);
                        chart += "@";
                    }
                    if (seat == 2)
                        chart += " ";
                    seat++;
                }
                chart += "\n";
                row++;
            }
            Console.WriteLine(chart);
            /*
            for (int hi=1;hi<=5;hi++)
            {
                Console.WriteLine(hi+" is hi value");
                for (int hey=1;hey<=10;hey++)
                {
                    //Console.Write(hey+" ");
                    Console.WriteLine(hey + "X" + hi + "=" + (hey * hi));
                }
                Console.WriteLine();
            }
            */
        }
        public void demoInfinite()
        {
            int count = 1;
            for (; ; count++)
            {
                if (count % 2 == 0)
                    continue;
                Console.WriteLine(count + " hi there!!!!!!!!!");
                Thread.Sleep(1000);
                
            }
            /*
            int count = 1;
            do
            {
                Console.WriteLine("Hai there! " + count);
                count++;
            } while (true);
            */
                /*
                int count = 1;
                while (true)
                {
                    Console.WriteLine("Hai there! "+count);
                    count++;
                }
                */
        }
        public void demoFor()
        {
            int available = 50, userAmount = 0, userRequired= 0;
            for (; available > 0;)
            {
                Console.WriteLine("Tell us how many product required ");
                userRequired=Convert.ToInt32(Console.ReadLine());
                if (userRequired <= available)
                {
                    Console.WriteLine("Enter the amount to buy");
                    userAmount = Convert.ToInt32(Console.ReadLine());
                    if (userAmount >= (userRequired*350))
                    {
                        Console.WriteLine("Stock " + userRequired + " has sold");
                        available-=userRequired;
                    }
                    else
                    {
                        Console.WriteLine("Stock " + userRequired + " hasn't sold");
                    }
                }
                else
                {
                    Console.WriteLine(userRequired + " amount of stock not available");
                }
            }
            /*
            int available = 50;
            int userAmount = 0;
            for (;available>0;)
            {
                Console.WriteLine("Enter the amount to buy");
                userAmount=Convert.ToInt32(Console.ReadLine());
                if (userAmount>=350)
                {
                    Console.WriteLine("Stock "+available+" has sold");
                    available--;
                }
                else
                {
                    Console.WriteLine("Stock "+available+" hasn't sold");
                }
            }
            */
            /*
            for (int step=10;step<=100;step++)
            {
                Console.WriteLine(step);
            }
            */
            /*
            int number1 = 0, number2 = 1, sum = 0;
            int howMany = Convert.ToInt32(Console.ReadLine());// 2
            if (howMany >= 2)
            {
                Console.WriteLine(number1);//0
                Console.WriteLine(number2);//1
                howMany -= 2;// 2-2=0
                for(;howMany>0;howMany--)
                {
                    sum = number1 + number2;
                    Console.WriteLine(sum);// 1
                    number1 = number2;
                    number2 = sum;
                }
            }
            else
            {
                Console.WriteLine("Can't generate fibonacci series");
            }
            */
        }
        public void demoDoWhile()
        {
            // fibonacci series : 0 1 1 2 3 5 8 13 21 ......
            int number1 = 0, number2 = 1, sum=0;
            int howMany=Convert.ToInt32(Console.ReadLine());// 2
            if (howMany>=2)
            {
                Console.WriteLine(number1);//0
                Console.WriteLine(number2);//1
                howMany-=2;// 2-2=0
                do
                {
                    sum = number1 + number2;
                    Console.WriteLine(sum);// 1
                    number1 = number2;
                    number2 = sum;
                    howMany--;//0
                }while(howMany>0);
            }
            else
            {
                Console.WriteLine("Can't generate fibonacci series");
            }
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
