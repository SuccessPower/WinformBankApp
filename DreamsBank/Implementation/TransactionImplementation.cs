using DreamsBank.Interface;
using DreamsBank.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace DreamsBank.Implementation
{
    public class TransactionImplementation : ITransaction
    {
        AccountModel account = new AccountModel();
        int limit = 1000;
        public double Deposit(double amount)
        {
            if(amount <= 0)
            {
                MessageBox.Show("cannot deposit negative amount, please input a new amount");
            }
            var transaction = new TransactionModel(amount);
            return account.Balance += amount;
        }

        public double Transfer(double amount, string accountNumber, string description)
        {
            if (account.Balance <= limit && amount <= 0)
            {
                MessageBox.Show($"Insuffient balance. Your minimum balance should be {limit}");
            }
            if (account.Balance <= 1000)
            {
                MessageBox.Show("insufficient balance. Your transaction limit is 1000");
            }
            var transaction = new TransactionModel(amount);
            return account.Balance -= amount;
            
        }

        public double Withdraw(double amount)
        {

            if (amount <= 0)
            {
                MessageBox.Show("cannot Withdraw negative amount, please input a new amount");
            }
            if(account.AccountType == "Current" && account.Balance <= limit)
            {
                MessageBox.Show($"Insuffienct balance. Your minimum balance is {limit}");
            }
            var transaction = new TransactionModel(amount);
            return account.Balance -= amount;
        }

    }
}
