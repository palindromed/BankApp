using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public static class Bank
    {
        #region Properties
        public static string Name { get; set; }
        #endregion

        #region Methods

        public static Customer CreateCustomer(string name, string emailAddress, string address)
        {
            var customer = new Customer() { Name = name,
                                            EmailAddress = emailAddress,
                                            Address = address};
            return customer;
        }

        #endregion
    }
}
