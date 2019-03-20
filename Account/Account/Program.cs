using System;
using Accounts.Entities;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting - Classe recebe da subclasse normalmente
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // Downcasting - subclasse para receber a superclasse tem q por casting
            // Tem que testar antes, para não dar erro de imcompatibilidade
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //BusinessAccount acc5 = (BusinessAccount)acc3; // Classes não compativeis, vai dar erro em tempo de exec.

            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                Console.WriteLine(acc5);
            }

            Console.WriteLine(acc);
            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
            Console.WriteLine(acc3);
            Console.WriteLine(acc4);
        }
    }
}
