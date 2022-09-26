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
    public partial class MainPage : Form
    {
        public static MainPage instance;
        private readonly string devToken = LoginPage.instance.token;
        public MainPage()
        {
            InitializeComponent();
            instance = this;
            instance.FormClosing += instance.MainPage_FormClosing;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            RestClient client = new RestClient();
            List<string> response = client.GetBotsNameList("https://community.cloud.automationanywhere.digital/v2/repository/workspaces/private/files/list", devToken);

            foreach (var item in response)
            {
                string botName = item.Split(':')[0].ToString();
                botList.Items.Add(botName);
            }
        }

        private void btnMigrate_Click(object sender, EventArgs e)
        {
            if (!checkTEST.Checked && !checkQA.Checked && !checkPROD.Checked)
            {
                statusTextBox.Text = "You need to select at least one environment!";
                return;
            }
            string botId = null;
            string selectedBot = botList.SelectedItems[0].Text;
            RestClient client = new RestClient();
            List<string> response = client.GetBotsNameList("https://community.cloud.automationanywhere.digital/v2/repository/workspaces/private/files/list", devToken);
            foreach (var item in response)
            {
                if (item.Split(':')[0].ToString() == selectedBot)
                {
                    botId = item.Split(':')[1].ToString();
                }
            }
            List<string> Bots = client.GetBotsId("https://community.cloud.automationanywhere.digital/", devToken, botId);
            foreach (var item in Bots)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                    //Environment.Exit(0);
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
    }
}
