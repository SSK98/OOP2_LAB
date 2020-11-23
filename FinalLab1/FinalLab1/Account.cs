using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab_1
{
   public abstract class Account
    {
        public double Balance { get; set; }
        public string AccName { get; set; }
        public string AccId { get; set; }
        public Account(string name, string id, double balance)
        {
            Balance = balance;
            AccName = name;
            AccId = id;
        }
        public abstract void Withdraw(double amount);


    }
}
