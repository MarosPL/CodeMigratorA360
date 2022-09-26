using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMigrator
{
    public partial class LoginPage : Form
    {
        public string token;
        public bool successAuthentication;
        public static LoginPage instance;
        public LoginPage()
        {
            InitializeComponent();
            instance = this;
            instance.FormClosing += instance.LoginPage_FormClosing;
            usernameTextbox.Text = "";
            passwordTextbox.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameTextbox.Text) || string.IsNullOrEmpty(passwordTextbox.Text))
                {
                    throw new Exception("Please provide user's login data");
                }

                RestClient client = new RestClient();
                (string, bool) response = client.getTokenByAuthenticate("https://community.cloud.automationanywhere.digital/v1/authentication", usernameTextbox.Text, passwordTextbox.Text);

                token = response.Item1;
                successAuthentication = response.Item2;

                if (!successAuthentication)
                {
                    statusTextBox.Text = token;
                }
                else
                {
                    statusTextBox.Text = "Logging...";
                    Task.Delay(2000);
                    new MainPage().Show();
                    instance.Hide();
                }
            }
            catch (Exception exc)
            {
                statusTextBox.Text = exc.Message.ToString();
            }
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
