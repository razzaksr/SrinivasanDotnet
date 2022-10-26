using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanBasic
{
    internal class ControlStatements
    {
        public void demoSwitch()
        {
            Console.WriteLine("Welcome to Derby Allan\nTell us your shirt size ");
            int size=Convert.ToInt32(Console.ReadLine());
            switch (size)
            {
                case 36:Console.WriteLine("Small size starts from Rs. 450");break;
                case 38:Console.WriteLine("Medium size starts from Rs. 600");break;
                case 40:Console.WriteLine("Large starts from 650");break;
                case 42:Console.WriteLine("XL starts from 700");break;
                default:Console.WriteLine("Invalid size "+size);break;
            }

            // travel ticket booking
            /*
            Console.WriteLine("Tell us destination to tarvel ");
            string destination=Console.ReadLine();
            switch (destination)
            {
                case "Chennai":case "chennai":case "villupuram":case "tambaram":
                    Console.WriteLine("Ultra delux coach @ 2.30pm");break;
                case "Banglore": case "banglore": case "silk board": case "electronics city": case "madiwala":
                    Console.WriteLine("Ac Seater coach @ 9.40pm");break;
                default:Console.WriteLine("No coaches are available to " + destination);break;
            }
            */
        }
        public void demoElseIfLadder()
        {
            // individual income tax
            Console.WriteLine("Enter the annual turn over");
            double annual = Convert.ToDouble(Console.ReadLine());
            double tax = 0, takeHome=0;
            if (annual >= 2.5 && annual <= 5.0)
            {
                Console.WriteLine("Have to pay 2.5% tax for "+annual);
                tax = 2.5;
            }
            else if (annual>5.0&&annual<=10.0)
            {
                Console.WriteLine("Have to pay 5% tax from "+annual);
                tax = 5;
            }
            else if (annual > 10.0 && annual <= 15.0)
            {
                Console.WriteLine("Have to pay 10% tax from " + annual);
                tax = 10;
            }
            else if (annual > 15.0 && annual <= 20.0)
            {
                Console.WriteLine("Have to pay 15% tax from " + annual);
                tax = 15;
            }
            else if (annual > 20.0 && annual <= 25.0)
            {
                Console.WriteLine("Have to pay 20% tax from " + annual);
                tax = 20;
            }
            else if (annual > 25.0)
            {
                Console.WriteLine("Have to pay 30% tax from " + annual);
                tax = 30;
            }
            else
            {
                Console.WriteLine("No need pay tax for "+annual);
            }
            takeHome = annual - (annual * tax) / 100;
            Console.WriteLine("Take home after tax deduction "+takeHome);
        }
        public void demoNestedIf()
        {
            Console.WriteLine("Select the network");
            string network = Console.ReadLine();
            if (network == "4G" || network == "4g")
            {
                Console.WriteLine("Oppo, Vivo, Redmi, Samsung available with 4G Tech");
                Console.WriteLine("Select budget ");
                int budget = Convert.ToInt32(Console.ReadLine());
                if (budget>=8000&&budget<=20000)
                {
                    Console.WriteLine("Z5Pro, 1T pro redmi, Narzo by realme available");
                }
                else
                {
                    Console.WriteLine("Samsung galaxy note 7 pro, redmi note 9 available");
                }
            }
            else
            {
                Console.WriteLine("Redmi, IQOO, Realme, Motorola and OnePlus available with 5G Tech");
            }
        }
        public void demoIfElse()
        {
            Console.WriteLine("Welcome to Redbus\nTell us desired boarding time ");
            float boardTime = Convert.ToSingle(Console.ReadLine());
            if (boardTime>6.00&&boardTime<=18.00)
            {
                Console.WriteLine("Semi sleeper, AC Seater available from Rs. 400");
            }
            else
            {
                Console.WriteLine("Sleeper and AC coaches available from Rs. 800");
            }
        }
        public void demoIf()
        {
            Console.WriteLine("Tell us required cash ");
            int required = Convert.ToInt32(Console.ReadLine());
            if (required%2000==0)
            {
                Console.WriteLine(required+" requested cash will be dispensed soon");
            }
        }
    }
}
