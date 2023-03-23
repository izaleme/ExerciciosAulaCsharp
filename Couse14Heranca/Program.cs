using System;
using Couse14Heranca.Entities;

namespace Couse14Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Ash", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Izabela", 0.0, 500.0);

            // UPCASTING = conversão da subclasse para a superclasse
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            // DOWNCASTING = conversão da superclasse para a subclasse
            // O downcasting deve ser usado somente quando necessário
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;     // <- dessa forma, ou:
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();   // usando downcasting para conseguir usar o UpdateBalance() do SavingsAccount
                Console.WriteLine("Update!");
            }
        }
    }
}
