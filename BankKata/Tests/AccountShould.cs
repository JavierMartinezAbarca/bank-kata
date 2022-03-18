using System;
using Code;
using Moq;
using Xunit;

namespace Tests
{
    public class AccountShould
    {
        [Fact]
        public void Test1()
        {
            var amount = 1000;
            var balance = 1000;
            var transaction = new Transaction(DateTime.Now, amount, balance);
            var repoMock = new Mock<ITransactionsRepository>();
            var account = new  Account(repoMock.Object);

            
            account.deposit(amount);

            repoMock.Verify(x => x.Add(It.IsAny<Transaction>()), Times.Once);
        }
    }
}