using System;

namespace Banking2C1.Models.Domein
{
    public class Transaction
    {
        public DateTime DateOfTranscation { get; }
        public TransactionType TransactionType { get; }
        public decimal Amount { get; }
        //methodes in java om bool terug te geven kan makkelijk als property geschreven worden
        public bool IsWithdraw {
            get { return TransactionType == TransactionType.Withdraw; }
        }
        public bool IsDeposit
        {
            get { return TransactionType == TransactionType.Deposit; }
        }

        public Transaction(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
            DateOfTranscation = DateTime.Today; //is value type, geen ref type;
        }
    }
}
