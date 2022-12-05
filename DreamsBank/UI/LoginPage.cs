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
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DreamsBank.UI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customer = File.ReadAllText(@"JsonDataBase.Json");
            List<UserModel> result = JsonConvert.DeserializeObject<List<UserModel>>(customer);
            //var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);
            
            if (result.Any(x => x.Email == txtBoxLoginEmail.Text && x.Password == txtBoxLoginPassword.Text))
            {
                TransactionUI transact = new TransactionUI(txtBoxLoginEmail.Text);
                this.Hide();

                transact.Show();

            }
            else
            {
                MessageBox.Show("Login Not Successfull");
            }
            
        }
    }
}
