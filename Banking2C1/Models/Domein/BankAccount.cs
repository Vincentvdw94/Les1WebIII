using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2C1.Models.Domein
{
    public class BankAccount //default visibiliteit is internal indien niet gedefiniëerd
    {



        /* private decimal _balance; //decimal aangeraden voor geldwaarden.


         public decimal GetBalance()
         {
             return _balance;
         }

         private void SetBalance(decimal value) {
             _balance = value;
         }*/

        // public decimal Balance { get; private set; } // is het zelfde als code bovenop;


        private decimal _balance;
        public  const decimal WithdrawCost = 0.10M; //m is voor deciMal;
        public decimal Balance
        {
            get { return _balance; }
            set
            {


                if (value < 0)
                {
                    throw new ArgumentException("value moet boven 0");
                }
                _balance = value;

            }
        }
        public void Deposit(decimal amount, int nrOfTimes = 1)//optionele parameter MOET waarde hebben, anders ist ne gewone;
        {

            Balance += amount * nrOfTimes;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount + WithdrawCost; //gaat automatisch naar setter;
        }

        private string _accountNumber;
        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {


                _accountNumber = value;
            }
        }

        #region MyRegion
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;

        } 
        #endregion

    }
}
