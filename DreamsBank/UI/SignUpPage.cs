using DreamsBank.Implementation;
using DreamsBank.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamsBank.UI
{
    
    public partial class signUpPage : Form
    {
        readonly StartingPage strPage = new StartingPage();
        public LoginPage LgPage = new LoginPage();  
        UserImplementation imp = new UserImplementation();
        

        public signUpPage()
        {
            InitializeComponent();
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUpPage_Click(object sender, EventArgs e)
        {
            
                string firstName = txtBoxFrstName.Text;
                string lastName = txtBoxLastName.Text;
                string email = txtBoxEmail.Text;
                string password = txtBoxPassword.Text;
                string confirmPassword = txtBoxConfirmPassword.Text;
                string accountNumber = generateAccountnum();
                double balance = 0;
                //string lblErrMsg = lblErrorMsg.Text;

            try
            {
                if (confirmPassword == password)
                {


                    var customer = File.ReadAllText(@"JsonDataBase.Json");


                    List<UserModel> result = JsonConvert.DeserializeObject<List<UserModel>>(customer);

                    var person = new UserModel(firstName, lastName, email, password, accountNumber, balance);

                    result.Add(person);

                    var json = JsonConvert.SerializeObject(result);
                    var fileInfo = new FileInfo(@"JsonDataBase.Json");
                    using (var users = new StreamWriter(fileInfo.Open(FileMode.Truncate)))
                    {
                        users.WriteLine(json);
                    }
            MessageBox.Show($"Hey {firstName}, Your account hass been Created Successfully");

            this.Hide();
            LgPage.Show();
                }

           
            }
            catch(Exception ex)
            {
               
                
            }


        }
        //This ends here
        private void txtBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpPage_Load(object sender, EventArgs e)
        {

        }
        //public static string RandomDigits(int length = 10)
        //{
        //    var random = new Random();
        //    string s = string.Empty;
        //    for (int i = 0; i < length; i++)
        //        s = String.Concat(s, random.Next(10).ToString());
        //    return s;
        //}

        public static string generateAccountnum()
        {
            Random random = new Random();
            int accountNum = random.Next(10000000, 990000099);
            var accNo = ($"00{accountNum}");
            return accNo.ToString();
        }
    }
}
