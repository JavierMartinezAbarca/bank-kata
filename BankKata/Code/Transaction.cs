using System;

namespace Code
{
    public class Transaction
    {
        private readonly DateTime _timestamp;
        private readonly int _amount;
        private readonly int _balance;

        public Transaction(DateTime timestamp, int amount, int balance)
        {
            _timestamp = timestamp;
            _amount = amount;
            _balance = balance;
        }
    }
}