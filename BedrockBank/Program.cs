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
            //Create an instance of an account == creating an object
            var account = new Account();
            account.AccountNumber = 123;
            account.Name = "Chitra Checking";
            account.Deposit(500);
            Console.WriteLine(account.Balance);
        }
    }
}
