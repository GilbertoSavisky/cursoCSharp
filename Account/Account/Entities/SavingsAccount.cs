using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRete { get; set; } // taxa de juros

        public  SavingsAccount (int number, string holder, double balance, double interestRate)
            : base (number, holder, balance)
        {
            InterestRete = interestRate;
        }

        public SavingsAccount() { }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRete;
        }
    }
}
