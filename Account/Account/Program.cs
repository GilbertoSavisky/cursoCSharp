using System;
using Accounts.Entities;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Maria", 500);
            Account acc1 = new SavingsAccount(1002, "Alex", 500, 0.01);
            Account acc2 = new BusinessAccount(1003, "José", 2000, 200);

            acc.WithDraw(10);
            acc1.WithDraw(10);
            acc2.WithDraw(100);

            Console.WriteLine(acc);
            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
        }       
    }
}
