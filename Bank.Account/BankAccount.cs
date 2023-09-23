using System;

namespace Bank.Account
{

    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(Balance), "The quantity must be positive.");

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(Balance), "The quantity must be positive.");

            if (amount > Balance)
                throw new InvalidOperationException("Insufficient balance.");

            Balance -= amount;
        }
    }
}
