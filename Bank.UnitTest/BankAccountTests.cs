using Bank.Account;
using NUnit.Framework;
using System;

namespace Bank.UnitTest
{
    public class BankAccountTests
    {

        [Test]
        public void Is_Deposit_Working_Correctly()
        {
            var account = new Bank.Account.BankAccount(100);
            decimal depositedAmount = 50;

            // Act
            account.Deposit(depositedAmount);

            // Assert
            Assert.AreEqual(100 + depositedAmount, account.Balance);
        }

        [Test]
        public void Is_Withdraw_Working_Correctly()
        {
            // Arrange (Preparation)
            var account = new BankAccount(100);
            decimal withdrawnAmount = 50;

            // Act
            account.Withdraw(withdrawnAmount);

            // Assert
            Assert.AreEqual(100 - withdrawnAmount, account.Balance);
        }

        [Test]
        public void Does_Withdraw_Give_Balance_Insufficient_Error ()
        {
            // Arrange (Preparation)
            var account = new BankAccount(100);
            decimal withdrawnAmount = 150;

            //Act and Assert
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(withdrawnAmount));
        }

        [Test]
        public void Does_Deposit_Negative_Amount_Give_Error()
        {
            // Arrange (Preparation)
            var account = new BankAccount(100);
            decimal depositedAmount = -1450;

            //Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Deposit(depositedAmount));
        }
    }
}