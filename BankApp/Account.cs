using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    {
        #region Variables
        private decimal balance;
        #endregion

        #region Static
        //private static int lastID = 0;
        #endregion

        #region Properties
        [Key]
        public int Id { get; private set; }
        // auto properties - backing field
        public string Name { get; set; }

        public decimal Balance
        {
            get
            {
                return balance;
            }
           private set
            {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }

        public virtual Customer Customer { get; set; }

        #endregion

        #region Constructor
        public Account()
        {
            //Id = ++lastID;
            Balance = 300;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {   
            Balance -= amount;
        }
        #endregion

    }
}
