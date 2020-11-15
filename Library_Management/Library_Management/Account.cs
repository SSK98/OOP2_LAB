using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class Account
    {
        private String accName;
        private String acId;
        private int balance;

        public String AccName
        { 
            get { return accName; } 
            set { accName = value; } 
        }
        public String AcId
        { 
            get { return acId; } 
            set { acId = value; }
        }
        public int Balance 
        {
            get { return balance; } 
            set { balance = value; }
        }

        public Account()
        {
            balance = 0;
            acId = null;
            accName = null;
        }

        public Account(String accName, String acId, int balance)
        {
            this.accName = accName;
            this.acId = acId;
            this.balance = balance;
        }

        public void deposit(int amount)
        {
            this.balance += amount;
        }

        public void withdraw(int amount)
        {
            if (this.balance < amount)
            {
                Console.WriteLine("Insufficient Balance.");
            }
            else
            {
                this.balance -= amount;
                Console.WriteLine("New Balance = " + balance);
            }
        }


        public void ShowInfo()
        {
            Console.WriteLine("Name: " + accName);
            Console.WriteLine("Account Number: " + acId);
            Console.WriteLine("Balance : " + balance);
        }
        public void transfer(int amount, Account receiver)
        {
            if (this.balance < amount)
            {
                Console.WriteLine("Insufficient Balance.");
            }
            else
            {
                if (receiver != null)
                {
                    receiver.balance += amount;
                    this.balance -= amount;
                    Console.WriteLine("Transfer Completed !!!");
                }
                else
                {
                    Console.WriteLine("Receiver Account Does not exist");
                }
            }
        }

    }
}
