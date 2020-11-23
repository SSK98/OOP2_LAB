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
            FixedAccount f = new FixedAccount("Sadman", "102", 1000,2022);
            f.Withdraw(200);
            SpecialSavings ss = new SpecialSavings("Sadman", "104", 1000, 2);
            ss.Withdraw(900);
            ss.Withdraw(200);
            ss.Withdraw(200);
            ss.Withdraw(200); // should exceed monthly limit
            Overdraft od = new Overdraft("Sadman", "101", 1000,500);
            od.Withdraw(1200);
            od.Withdraw(100);
            od.Withdraw(300); // should exceed OVerhead limit
        }
    }
}
