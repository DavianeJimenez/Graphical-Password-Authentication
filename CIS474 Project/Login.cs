using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CIS474_Project
{
    public partial class Login : Form
    {
        SQLStuff sql = new SQLStuff();
        Security hash = new Security();
        public Login()
        {
            InitializeComponent();
            warningText.Hide();
        }

        //Verifies the entered information before moving on to the passimage selection
        private void loginButton_Click(object sender, EventArgs e)
        {
            bool verification = sql.CheckLogin(username.Text, email.Text, hash.Sha256(password.Text));

            if (String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Text))
            {
                warningText.Show();
                warningText.Text = "Please fill out all required fields.";
            }
            else if (verification == true)
            {

                PassImageSelect passImage = new PassImageSelect(email.Text);

                username.Clear();
                email.Clear();
                password.Clear();

                this.Hide();
                DialogResult result = passImage.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    this.Show();
                    passImage.Close();
                }
                else if (result == DialogResult.OK)
                {
                    this.Show();
                }
            }
            else
            {
                warningText.Show();
                warningText.Text = "Incorrect username, email, or password.";
            }
        }

        //Opens the form to create a new account
        private void createAccountButton_Click(object sender, EventArgs e)
        {

            username.Clear();
            email.Clear();
            password.Clear();

            CreateAccount createAccount = new CreateAccount();

            this.Hide();
            DialogResult result = createAccount.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                createAccount.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
