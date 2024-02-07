using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.LSP
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public virtual  void WithDraw(decimal amount)
        {
            if (Balance > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insuffiecient Balance : ");
            }
        }
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit: {amount}, Total Amount: {Balance}");
        }
    }
}
