using System;
using NUnit.Framework;
using WebBank;

namespace WebBank.test
{
    [TestFixture]
    public class AccountTest
    {
        [Test]
        public void TransferFunds()
        {
            Assert.True(true);
            BankAccount source = new BankAccount();
            BankAccount destination = new BankAccount();
            source.Deposit(200F);
            Assert.AreEqual(200F, source.balance);
            source.Transfer(destination, 100F);
            Assert.AreEqual(100F, source.balance);
            Assert.AreEqual(100F, destination.balance);
        }
    }
}

