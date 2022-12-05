using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamsBank.Model
{
    public class UserModel
    {



        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }




        public UserModel()
        {

        }

        public UserModel(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public UserModel(string firstName, string lastName, string email, string password, string accountNumber, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            AccountNumber = accountNumber;
            Balance = balance;

        }
    }
}
