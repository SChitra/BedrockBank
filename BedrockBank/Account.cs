using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    /// <summary>
    /// This class provides information for 
    /// a Bedrock account
    /// </summary>
    public class Account

    {
        #region Variables
        /// <summary>
        /// Shared memeory for storing the last account number
        /// </summary>
        private static int lastAccountNumber = 0;


        #endregion
        #region Properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account number for the account. Private for set so nobody can change it
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// 
        /// Balance in account
        /// </summary>
        
        public decimal Balance { get; private set; }

        public int SSN { get; set; }
        #endregion

        #region Constructors
        //Default Constructor
        public Account()
        {
           AccountNumber = ++lastAccountNumber;
        }

        public Account(string name):this()
        {
            this.Name = name;
        }
        public Account(string name, decimal amount):this(name)
        {
            //Name = name;
            Deposit(amount);
        }

        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Money to depsoit</param>
        /// <returns>New balance</returns>
        public decimal Deposit(decimal amount)
        {
           //Balance = Balance + amount;
            Balance += amount;
            return Balance;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception></exception>
        public decimal Withdrawal(decimal amount)
        {
            if(amount <0)
            {
                throw new ArgumentNullException("Balance should be atleaset 1$");
            }
            if(amount > Balance)
            {
                throw new ArgumentException("Insufficient funds");
            }
            Balance -= amount;
            return Balance;
        }
        #endregion






    }
}
