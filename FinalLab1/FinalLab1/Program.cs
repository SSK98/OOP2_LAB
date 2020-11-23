using FinalLab_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount s = new SavingAccount("Sadman", "101", 1000);
            s.Withdraw(800);
            FixedAccount f = new FixedAccount("Sadman", "101", 1000,2022);
            f.Withdraw(200);
        }
    }
}
