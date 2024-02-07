using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.LSP
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }
        public CurrentAccount(string accountNumber, decimal balance, decimal overdraftLimit)
            : base(accountNumber, balance)
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void WithDraw(decimal amount)
        {
            if (amount <= Balance + OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"AccountNumber: {AccountNumber}, Exceeded Overdraft Limit.");
            }
        }
    }
}
