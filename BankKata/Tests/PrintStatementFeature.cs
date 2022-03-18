using System;
using Code;
using Moq;
using Xunit;

namespace Tests
{
    // Given a client makes a deposit of 1000 on 10-01-2012
    // And a deposit of 2000 on 13-01-2012
    // And a withdrawal of 500 on 14-01-2012
    // When they print their bank statement
    // Then they would see:
    public class PrintStatementFeature
    {
        [Fact]
        public void AcceptanceCriteriaTest()
        {
            const string expected = @"Date || Amount || Balance
                            14/01/2012 || -500 || 2500
                            13/01/2012 || 2000 || 3000
                            10/01/2012 || 1000 || 1000";

            var repo = new TransactionsRepository();
            var account = new Account(repo);
            account.deposit(1000);
            account.deposit(2000);
            account.withdraw(500);

            account.printStatement();
            
            Assert.Equal(expected, Console.ReadLine());
        }
    }
}