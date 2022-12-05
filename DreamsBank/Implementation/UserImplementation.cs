using DreamsBank.Interface;
using DreamsBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace DreamsBank.Implementation
{
    public class UserImplementation : IUser
    {
       List< UserModel> user = new List<UserModel>();
        AccountModel account = new AccountModel();

        //public string DeleteAccount(string accountNumber)
        //{
        //    //return accountNumber = "Account has been deleted";
        //    return account.AccountNumber = accountNumber;
        //}

        public void Login(string email, string password)
        {
            var user1 = new UserModel(email, password);
            user.Add(user1);
            MessageBox.Show("Login Successfull");
        }

        public void RegisterNewAccount(string firstName, string lastName, string email, string password, string confirmPassword, string accountNumber)
        {
    
                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Incorrect password");
                    }
            //MessageBox.Show($"Registration Successfull! Your Account Number is {accountNumber}");


        }

        public static string RandomDigits(int length = 10)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }

        /*public static string Login()
        {
            throw new NotImplementedException();
        }*/

        //public static double Add(double x, double y)
        //{
        //    return x + y;
        //}

        //public static string Login()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
