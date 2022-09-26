using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace CodeMigrator
{
    public class RestClient
    {
        public (string, bool) getTokenByAuthenticate(string url, string userName, string userPassword)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var endpoint = new Uri(url);
                    var newPost = new GetToken()
                    {
                        username = userName,
                        password = userPassword
                    };

                    var newPostJson = JsonConvert.SerializeObject(newPost);
                    var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = client.PostAsync(endpoint, payload).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        JObject jObject = (JObject)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                        return (jObject.GetValue("token").ToString(), response.IsSuccessStatusCode);
                    }
                    else
                    {
                        return (response.StatusCode.ToString(), response.IsSuccessStatusCode);
                    }
                }
            }
            catch (Exception e)
            {
                return ("Error Description: " + e.Message.ToString(), false);
            }
        }

        public List<string> GetBotsNameList(string url, string token)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Add("X-Authorization", token);
                    var endpoint = new Uri(url);
                    string json = @"{'filter': 
                                        {'operator': 'eq',
                                        'field': 'folder',
                                        'value': 'true'},
                                    'sort': [{'field': 'id',
                                    'direction': 'asc'}]}";

                    var payload = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = client.PostAsync(endpoint, payload).Result;

                    if (response.IsSuccessStatusCode)
                    {

                        List<string> values = new List<string>();
                        JObject jObject = (JObject)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

                        var list = jObject["list"];

                        foreach (var item in list)
                        {
                            string botName = item["name"].ToString();
                            string id = item["id"].ToString();
                            if (botName != "Bots" &&
                                botName != "Bot Store" &&
                                botName != "Sample bots" &&
                                botName != "Document Workspace Processes")
                            {
                                values.Add(botName + ":" + id);
                            }
                        }
                        return values;
                    }
                    else
                    {
                        return new List<string>();
                    }

                }
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }
        public List<string> GetBotsId(string url, string token, string parentBotId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-Authorization", token);
                    var endpoint = new Uri(url + "v2/repository/folders/" + parentBotId + "/list");
                    string json = @"{}";
                    var payload = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = client.PostAsync(endpoint, payload).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        List<string> values = new List<string>();
                        JObject jObject = (JObject)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

                        var list = jObject["list"];

                        foreach (var item in list)
                        {
                            values.Add(item["id"].ToString());
                        }
                        return values;
                    }
                    else
                    {
                        return new List<string>();
                    }

                }
            }
            catch (Exception)
            {

                return new List<string>();
            }
        }
        public string ExportBots(string url, string token, string outputFileName, string includePackages, List<string> bots)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string json = null;
                    client.DefaultRequestHeaders.Add("X-Authorization", token);
                    var endpoint = new Uri(url);
                    if (bots.Count == 1)
                    {
                        json = @"{'name': '" + outputFileName + "'," +
                                 "'fileIds': [" + bots.ElementAt(0) +
                                 "],'includePackages': " + includePackages + "}";
                    }
                    else
                    {
                        string joined = string.Join(",", bots);
                        json = @"{'name': '" + outputFileName + "'," +
                                 "'fileIds': [" + joined +
                                 "],'includePackages': " + includePackages + "}";
                    }

                    var payload = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync(endpoint, payload).Result;

                    return "StatusCode: " + response.StatusCode.ToString() + " - Response: " + response.Content.ReadAsStringAsync().Result;

                }
            }
            catch (Exception e)
            {
                return "Error Descritption: " + e.Message.ToString();
            }

        }
    }
}
