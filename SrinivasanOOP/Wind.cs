using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    internal class Bank
    {
        public static String operator-(Bank obj,int amount)
        {
            if (amount<=obj.accBal)
            {
                obj.accBal -= amount;
                return amount + " has been withdrawn successfully";
            }
            else
            {
                return "Insufficient balance";
            }
        }
        public long accNum { set; get; }
        public double accBal { set; get; }
        public override string ToString()
        {
            return "Number is "+accNum+" balance is "+accBal;
        }
    }
    internal class Wind
    {
        public static String operator%(Wind obj1, Wind obj2)
        {
            if (obj1.macro>=obj2.macro)
            {
                return obj1.ToString()+" is greatest object";
            }
            else
            {
                return obj2.ToString() + " is greatest object";
            }
        }
        public static int operator +(Wind obj1,Wind obj2)
        {
            obj1.micro *= obj2.micro;
            obj2.micro = obj1.micro / obj2.micro;
            obj1.micro /= obj2.micro;
            
            return 0;
        }
        public Wind() { }
        public Wind(int macro, double micro)
        {
            this.macro = macro;
            this.micro = micro;
        }
        public override string ToString()
        {
            return macro+" "+micro;
        }
        public int macro { set; get; }
        public double micro { set; get; }
    }
}
