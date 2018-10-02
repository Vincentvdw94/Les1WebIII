using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2C1.Models.Domein
{
   public  class SavingsAccount : BankAccount
    {
        private const decimal WithdrawCost = 0.10M;
        public decimal InterestRate { get ; private set; }
        public SavingsAccount(string accountNumber, decimal interestRate): base(accountNumber)
        {
            InterestRate = interestRate;

        }

        //keyword override is nodig bij overschrijven van methodes in subklassen.
        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount + WithdrawCost);

        }

        public override string ToString()
        {
            return $"Acount number : {AccountNumber} --- balance : {Balance}";
        }

        public override bool Equals(object obj)
        {
            BankAccount ba = obj as BankAccount; // as word gebruikt om te casten, als niet gaat krijg je null ipv exception
            if (ba == null)
                return false;
            return ba.AccountNumber == AccountNumber;
        }

        public override int GetHashCode() // altijd doen als Equals methode wordt overgeschreven.
        {
            return AccountNumber.GetHashCode();
        }

    }
}
