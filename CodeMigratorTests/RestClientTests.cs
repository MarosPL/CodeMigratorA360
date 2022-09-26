using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMigrator.Tests
{
    [TestClass()]
    public class RestClientTests
    {
        [TestMethod()]
        public void getTokenByAuthenticateTest()
        {
            var client = new RestClient();
            (string, bool) response = client.getTokenByAuthenticate("https://community.cloud.automationanywhere.digital/v1/authentication", "email", "haslo");

            Console.WriteLine(response.Item1);
            Console.WriteLine(response.Item2);
        }

        [TestMethod()]
        public void GetBotsNameListTest()
        {
            var client = new RestClient();
            string token = client.getTokenByAuthenticate("https://community.cloud.automationanywhere.digital/v1/authentication", "email", "haslo").Item1;
            List<string> response = client.GetBotsNameList("https://community.cloud.automationanywhere.digital/v2/repository/workspaces/private/files/list", token);

            foreach (var item in response)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod()]
        public void GetBotsIdTest()
        {
            var client = new RestClient();
            string token = client.getTokenByAuthenticate("https://community.cloud.automationanywhere.digital/v1/authentication", "email", "haslo").Item1;
            List<string> bots = client.GetBotsId("https://community.cloud.automationanywhere.digital/", token, "botID");

            Console.WriteLine(bots.ElementAt(0));
            string joined = string.Join(",", bots);
            Console.WriteLine(joined);

            //foreach (var item in bots)
            //{
            //    Console.WriteLine(item);
            //}
        }

        [TestMethod()]
        public void ExportBotsTest()
        {
            var client = new RestClient();
            string token = client.getTokenByAuthenticate("https://community.cloud.automationanywhere.digital/v1/authentication", "email", "haslo").Item1;
            List<string> bots = client.GetBotsId("https://community.cloud.automationanywhere.digital/", token, "botID");
            string exportBots = client.ExportBots("https://community.cloud.automationanywhere.digital/v2/blm/export", token, "TestFile", "false", bots);
            Console.WriteLine(exportBots);
        }
    }
}