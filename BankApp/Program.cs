using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Account();
            //var account = new Account();
            //account.Name = "Hannah";
            //account.Deposit(400);
            //account.Withdraw(200);
            //var account2 = new Account();
            //account2.Name = "Scott";
            //account2.Deposit(1000);
            //Console.WriteLine("ID: {0}, Name: {1}, Balance: {2}",
            //                  account.Id, account.Name, account.Balance);
            //Console.WriteLine("ID: {0}, Name: {1}, Balance: {2}",
            //                  account2.Id, account2.Name, account2.Balance);

            //Console.ReadLine();
            Bank.CreateCustomer
                ("Hannah", "hannahkrager@gmail.com", "Seattle WA");
           
        }
    }
}
