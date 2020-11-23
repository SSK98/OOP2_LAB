using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab_1
{
    class SpecialSavings : Account
    {
        public int MinimalTrans { get; set; }
        public int TransCount { get; set; }
        private double MinimumBalance;

        public SpecialSavings(string name, string id, double balance, int minTrans) : base( name, id, balance)
        {
                MinimalTrans = minTrans;
                TransCount = 0;
                MinimumBalance = .2 * balance;
         }

    public override void Withdraw(double amount)
    {
            if(MinimalTrans > TransCount)
            {
                if (Balance - amount < MinimumBalance)
                {
                    Balance += amount;
                }
                else
                {
                    Console.WriteLine("Cannot Withdraw... Balance will be less than Minimum Balance");
                }
            }
            else
            {
                Console.WriteLine("Cannot Withdraw... Maximum Monthly Transaction Reached ");
            }
    }


}
}
