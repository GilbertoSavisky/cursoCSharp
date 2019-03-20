using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts.Entities
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

        // Para o método puder ser sobrescrito tem que usar a palavra 'Virtual'
        public virtual void WithDraw(double amount)
        {
            Balance -= amount;
            Console.Write("\nSaque realizado com sucesso ");
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
