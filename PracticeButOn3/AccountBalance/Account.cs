using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3.AccountBalance {
    class Account : IBalanceable, IWithdrawable, IDepositable {

        public double Balance { get; set; }
        public double Interest { get; set; }
        public string Name { get; set; }
        public string CustFN { get; set; }
        public string CustLN { get; set; }
        public double MonthlyFee { get; set; }

        public void Deposit(double amount) {
           Balance = GetBalance() + amount;
         }

        public double GetBalance() {
            return Balance;
        }

        public void SetBalance() {
            Balance = GetBalance();
        }

        public void Withdraw(double amount) {
            if (Balance > amount) {
                Balance = GetBalance() - amount;
            }
        }

        public double Fees() {
            double NewBal = GetBalance() - MonthlyFee;
            return NewBal;
        }

    }
}
