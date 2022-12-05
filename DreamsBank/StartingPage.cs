using DreamsBank.Interface;
using DreamsBank.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamsBank
{
    public partial class StartingPage : Form
    {
        //readonly LoginPage loginPg = new LoginPage();
        //public signUpPage signUp = new signUpPage();
      //  public signUpPage register = new signUpPage();
       public IAccount _account;
        public StartingPage()
        {
            InitializeComponent();
        }
        public StartingPage(IAccount account)
        {
            _account = account;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRegStart_Click(object sender, EventArgs e)
        {
            signUpPage signUpPage = new signUpPage();
            signUpPage.Show();

        }

        private void btnLoginStart_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

    }
}
