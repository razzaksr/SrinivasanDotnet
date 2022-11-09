using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    internal class Wallet:DebitCard
    {
        public void transfer(Wallet obj, int amount)
        {
            if (amount < this.Balance)
            {
                this.Balance -= amount;
                obj.Balance += amount;
                Console.WriteLine(amount + " successfully transferred to " + obj.Holder);
            }
            else
            {
                Console.WriteLine(amount + " failed to transfer to " + obj.Holder);
            }
        }
    }
    class DebitCard : Account
    {
        public void deposit(int cash)
        {
            Balance += cash;
            Console.WriteLine(cash + " has deposited to account " + Number);
        }
    }
    class Account
    {
        public String Holder { set; get; }
        public Double Balance { set; get; }
        public long Number { set; get; }

        public override string ToString()
        {
            return "Account details: " + Holder + " " + Number + " " + Balance + "\n";
        }
    }
}
