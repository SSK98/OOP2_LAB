using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab_1
{
    class SavingAccount : Account
    {
        public SavingAccount(string name, string id, double balance) : base( name, id, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if ((Balance - amount )< 500) Console.WriteLine("Cannot withdraw below 500 taka.Current Balance:    " + Balance);
            else Balance += amount;
        }
    }
}
