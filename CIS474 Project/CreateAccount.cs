using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace CIS474_Project
{
    public partial class CreateAccount : Form
    {

        Security hash = new Security();
        SQLStuff sql = new SQLStuff();
        bool uniqueUsername;
        bool uniqueEmail;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void newUsername_Leave(object sender, EventArgs e)
        {
            uniqueUsername = sql.UniqueUsername(newUsername.Text);
            if (uniqueUsername == false)
            {
                usernameWarningText.Show();
            }
            else
            { 
                usernameWarningText.Hide();
            }

        }

        private void newEmail_Leave(object sender, EventArgs e)
        {
            uniqueEmail = sql.UniqueEmail(newEmail.Text);
            if (uniqueEmail == false)
            {
                emailWarningText.Show();
            }
            else
            {
                emailWarningText.Hide();
            }

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            //Regex for password strength. Checks for a number, an upper and lowercase letter, a symbol, and at least 8 characters
            Regex passwordValidation = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\s\d]).{8,}$");

            if (String.IsNullOrEmpty(newUsername.Text) || String.IsNullOrEmpty(newPassword.Text) || String.IsNullOrEmpty(confirmPassword.Text))
            {
                passWarningText.Show();
                passWarningText.Text = "Please fill in all required fields.";
            }
            else if (newPassword.Text != confirmPassword.Text)
            {
                passWarningText.Show();
                passWarningText.Text = "Passwords do not match.";
            }
            else if (passwordValidation.IsMatch(newPassword.Text) == false || newPassword.Text.Any(Char.IsWhiteSpace))
            {
                passWarningText.Show();
                passWarningText.Text = "Please make sure your password meets the following criteria:\n" +
                                    "At least one upper and lowercase letter\n" +
                                    "At least one number\n" +
                                    "At least one symbol\n" +
                                    "At least 8 characters long\n" +
                                    "No whitespaces";
            }
            else if (uniqueUsername == false || uniqueEmail == false)
            {
                //Do nothing, the user already has a warning
            }
            else
            {
                PassImageCreation createPassImage = new PassImageCreation(newUsername.Text, newEmail.Text, hash.Sha256(newPassword.Text));
                this.Hide();
                DialogResult result = createPassImage.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    this.Show();
                    createPassImage.Close();
                }
                else if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
