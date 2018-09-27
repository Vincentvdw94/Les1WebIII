using Banking2C1.Models.Domein;
using System;

namespace Banking2C1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBa = new BankAccount("123-1231312-12");
            BankAccount myBa2 = new BankAccount("123-1456874-12",1000);

            Console.WriteLine($"Balance is {myBa.Balance} euro"); // $ voor de string om in de string naar variablen te refereren
            Console.WriteLine($"Balance is {myBa2.Balance} euro"); // $ voor de string om in de string naar variablen te refereren
            myBa2.Withdraw(50);
            Console.WriteLine($"Balance is {myBa2.Balance} euro"); // $ voor de string om in de string naar variablen te refereren
            myBa2.Deposit(50, 5);
            Console.WriteLine($"Balance is {myBa2.Balance} euro"); // $ voor de string om in de string naar variablen te refereren

            Console.ReadKey();
        }
    }
}
