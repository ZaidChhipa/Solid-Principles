using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.LSP
{
    public class SavingAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingAccount(string accountNumber, decimal balance, decimal interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }
        public override void WithDraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Insufficient Funds, Available Funds: {Balance}");
            }
        }
    }
}
