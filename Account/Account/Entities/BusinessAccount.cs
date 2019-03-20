using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder,balance)
        {
            LoanLimit = loanLimit; 
        }

        public void Loan(double amount)
        {
            if(LoanLimit >= amount)
                Balance += amount;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);// reaproveitar o método da superclasse
            Console.Write("da conta empresarial!");
            Console.WriteLine("\nSerá descontado R$ 2,00");
            Balance -= 2;
        }
    }
}
