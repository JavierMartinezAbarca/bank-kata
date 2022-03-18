using System;

namespace Code
{
    public class Account : IAccountService
    {
        private readonly ITransactionsRepository _transactionsRepository;
        private int _balance;

        public Account(ITransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }

        public void deposit(int amount)
        {
            _balance += amount;
            
            _transactionsRepository.Add((new Transaction(DateTime.Now, amount, _balance)));
        }

        public void withdraw(int amount)
        {
            throw new System.NotImplementedException();
        }

        public void printStatement()
        {
            throw new System.NotImplementedException();
        }
    }
}