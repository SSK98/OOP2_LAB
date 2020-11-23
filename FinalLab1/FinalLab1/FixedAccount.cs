using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab_1
{
    class FixedAccount : Account
    {
        public int TenureYear { get; set; }
        public FixedAccount(string name, string id, double balance, int year) : base( name,  id,  balance)
        {
            TenureYear = year;
        }
    public override void Withdraw(double amount)
    {
            if(DateTime.Now.Year > TenureYear)
            {
                if(Balance - amount >= 0)
                {
                    Balance += amount;
                }
                else
                {
                    Console.WriteLine("Cannot Withdraw... Balance will be less than ZERO.Current Balance:    " + Balance);
                }
            }
            else
            {
                Console.WriteLine("Cannot Withdraw... Account Did not reach Tenure Year.Your accounr Tenure Year :  "+ TenureYear);
            }
    }
    }
}
