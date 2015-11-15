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
    class Account

    {
        #region Properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account number for the account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// 
        /// Balance in account
        /// </summary>
        
        public decimal Balance { get; set; }
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

        public decimal Withdrawal(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion






    }
}
