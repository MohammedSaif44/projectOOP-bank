using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    public class Current_account : Account
    {
        public double Overdraft_Limit { get; set; }
        public Current_account(int numofaccount, double balance,double overdraft_limit) : base(numofaccount, balance)
        {
            this.Overdraft_Limit = overdraft_limit;

        }

        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        public override void Withdrawing(double amount)
        {
            if(amount>Balance)
            Balance -= amount;
        }
    }
}
