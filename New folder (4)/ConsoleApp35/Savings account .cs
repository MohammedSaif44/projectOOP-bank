using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Savings_account : Account
    {
        public decimal Interest_Rate { get; set; }
        public Savings_account(int numofaccount, double balance,decimal interest_tate) : base(numofaccount, balance)
        {
            this.Interest_Rate = interest_tate;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        public override void Withdrawing(double amount)
        {
            if(Balance>amount)
               Balance -= amount;
        }
    }
}
