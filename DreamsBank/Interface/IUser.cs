using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DreamsBank.Interface
{
    internal interface IUser
    {
        void RegisterNewAccount(string firstName, string lastName, string email, string password, string confirmPassword, string accountNumber);

        void Login(string email, string password);

        //void DeleteAccount(string accountNumber);
    }
}
