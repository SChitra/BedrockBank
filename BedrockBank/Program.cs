using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)

        {

            var account = BankFactory.CreateAccount("Chitra Checking", 500);
            //Create an instance of an account == creating an object
            //var account = new Account();
            ////account.AccountNumber = 123;
            //account.Name = "Chitra Checking";
            //account.Deposit(500);
            Console.WriteLine("Name: {0},Account Number: {1}, Balance: {2:c}",account.Name,account.AccountNumber,account.Balance);

            var savingsAccount = BankFactory.CreateAccount("CSethu", 10);
            //var savingsAccount = new Account();
            //savingsAccount.Name = "CSethu";
            //savingsAccount.Deposit(10);
            //Exception handling
            try
            {
                savingsAccount.Withdrawal(100);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ooops something went wrong {0}", ex.Message);
            }
            Console.WriteLine("Name: {0},Account Number: {1}, Balance: {2:c}", savingsAccount.Name, savingsAccount.AccountNumber, savingsAccount.Balance);
        }
    }
}
