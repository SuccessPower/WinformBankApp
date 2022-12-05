using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsBank.Interface
{
    public interface IAccount
    {
        double getAccountBalance();
        string GetAccountStatement();
        string GetAccount();
        //string CreateAccount();

    }
}
