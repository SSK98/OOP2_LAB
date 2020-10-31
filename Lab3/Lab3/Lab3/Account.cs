using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Account
    {
        string accName;
        string acid;
        int balance;
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(int ammount)
        {
            balance +=  ammount;
        }
        public void Withdraw(int ammount)
        {
            balance -=  ammount;
        }

    }
}
