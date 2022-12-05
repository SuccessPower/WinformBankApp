using DreamsBank.Interface;
using DreamsBank.Model;
using DreamsBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsBank.Implementation
{
    public class AccountImplementation : IAccount
    {
        AccountModel account = new AccountModel();
        
        public AccountImplementation(string id, double firstDepoist, int accountType )
        {
            account.UserId = id;
            account.Balance += firstDepoist;
            account.AccountType = accountType == 0 ? "Savings" : "Current";
            //account.AccountNumber = RandomDigits();
            account.TransactionsList = new List<TransactionModel>();

            
        }

        public AccountImplementation()
        {
        }

        //public string CreateAccount()
        //{
        //    return account.AccountNumber = RandomDigits();
        //}
        public string GetAccount()
        {
            return account.AccountNumber;
            
        }

        public double getAccountBalance()
        {
            return account.Balance;
        }

        public string GetAccountStatement()
        {
            throw new NotImplementedException("yet to write the implementation for this");
        }

        

    
    }
}
