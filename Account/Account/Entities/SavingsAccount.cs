using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts.Entities
{
    sealed class SavingsAccount : Account
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

        // 'Sealed' -> quer dizer que esse método não pode ser sobrescrito em uma nova classe
        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);// reaproveitar o método da superclasse
            Console.Write("da poupança!");
            Console.WriteLine("\nSerá descontado R$ 5,00");
            Balance -= 5;
        }
    }
}
