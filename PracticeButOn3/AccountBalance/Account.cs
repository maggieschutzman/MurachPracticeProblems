using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3.AccountBalance {
    class Account : IBalanceable, IWithdrawable, IDepositable {

        public double Balance { get; set; }
        public double Interest { get; set; }
        public string Name { get; set; }

        public void deposit(double amount) {
           Balance = GetBalance() + amount;
         }

        public double GetBalance() {
            return Balance;
        }

        public void SetBalance() {
            Balance = GetBalance();
        }


        public void Withdraw(double amount) {
            Balance = GetBalance() - amount;
        }

    }
}
