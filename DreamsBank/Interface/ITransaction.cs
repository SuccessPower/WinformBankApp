using DreamsBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsBank.Interface
{
    public interface ITransaction
    {
        double Deposit(double amount);
        double Withdraw(double amount);
        double Transfer(double amount, string accountNumber, string description);
    }
}
