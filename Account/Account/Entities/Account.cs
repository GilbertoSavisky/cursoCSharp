using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public Account() { }

        public double WithDraw(double amount)
        {
            return Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return $"CC: {Number}\nName: {Holder}\nSaldo: {Balance}\n";
        }
    }
}
