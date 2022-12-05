using DreamsBank.Implementation;
using DreamsBank.Interface;
using DreamsBank.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DreamsBank.UI
{
    public partial class TransactionUI : Form
    {

        AccountImplementation accountImp = new AccountImplementation();

        string emailLoginCup;
        public TransactionUI(string regEmail)
        {
            emailLoginCup = regEmail;
            InitializeComponent();
            
        }

        private void depositAmount_Click(object sender, EventArgs e)
        {
            //var customer = File.ReadAllText(@"JsonDataBase.Json");
            //var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);
            //double amount = double.Parse(amountToDepo.Text);

            //var LoggedInUser = result.Users.FirstOrDefault(x => x.Email == emailLoginCup);

            //LoggedInUser.Balance += amount;
            //lblAccountBal.Text = LoggedInUser.Balance.ToString();
        }

        private void amountToDepo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblAcctNo_Click(object sender, EventArgs e)
        {

        }

        private void tabWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAccountNum_Click(object sender, EventArgs e)
        {
            

            //accountNum = accountImp.GetAccount();
            //lblAccountNum.Text = accountNum;


        }

        private void TransactionUI_Load(object sender, EventArgs e)
        {
            List<UserModel> result;
            UserModel LoggedInUser;
            DeserializeMethod(out result, out LoggedInUser);

            
            lblAccountBal.Text = ($"{LoggedInUser.Balance.ToString()}");
            lblAccountNum.Text = ($"Welcome {LoggedInUser.FirstName}");


        }

        private void btnDepoAmt_Click(object sender, EventArgs e)
        {
            List<UserModel> result;
            UserModel LoggedInUser;
            DeserializeMethod(out result, out LoggedInUser);


            //var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);
            double amount = double.Parse(amountToDepo.Text);
            LoggedInUser.Balance += amount;

            var resultJason = JsonConvert.SerializeObject(result);
            File.WriteAllText(@"JsonDataBase.Json", resultJason);

            lblAccountBal.Text = LoggedInUser.Balance.ToString();

            MessageBox.Show($"Dear {LoggedInUser.FirstName}, {amount} Has been added to your account");


        }

        private void DeserializeMethod(out List<UserModel> result, out UserModel LoggedInUser)
        {
            var customer = File.ReadAllText(@"JsonDataBase.Json");
            result = JsonConvert.DeserializeObject<List<UserModel>>(customer);
            LoggedInUser = result.FirstOrDefault(x => x.Email == emailLoginCup);
        }

        private void lblAccountBal_Click(object sender, EventArgs e)
        {

        }
    }
}
