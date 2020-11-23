
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab_1
{
    class Overdraft : Account
    {
        public double OverDraftAmount { get; set; }
        public Overdraft(string name, string id, double balance, double overDraftAmount) : base(name, id, balance)
        {
            OverDraftAmount = overDraftAmount;
        }
        public override void Withdraw(double amount)
        {
            if (amount < Balance + OverDraftAmount)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Cannot Withdraw.Current Balance" + Balance);
            }
        }
    }
}
