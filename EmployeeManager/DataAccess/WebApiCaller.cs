using System;
using System.Configuration;
using System.Net.Http;
using EmployeeManager.Helpers;
using Newtonsoft.Json.Linq;

namespace EmployeeManager.DataAccess
{
    public class WebApiCaller
    {
        public string CallGetOperation(string requestUri, string property = "data")
        {
            try
            {
                using (HttpClient httpClient = GetClient())
                {
                    var response = httpClient.GetAsync(requestUri).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        var dataObject = JObject.Parse(content)[property].ToString();
                        return dataObject;
                    }
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                return string.Empty;
            }
        }
        public string CallPostOperation(string requsetUri, string jsonContent, string property = "data")
        {
            try
            {
                using (HttpClient httpClient = GetClient())
                {
                    StringContent byteContent = HttpContentConverter.ConvertFromJson(jsonContent);
                    var response = httpClient.PostAsync(requsetUri, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        var dataObject = JObject.Parse(content)[property].ToString();
                        return dataObject;
                    }
                    return string.Empty;

                }
            }
            catch (Exception ex)
            {
                Logger.Log($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                return string.Empty;
            }
        }



        public string CallPutOperation(string requsetUri, string jsonContent, string property = "data")
        {
            try
            {
                using (HttpClient httpClient = GetClient())
                {
                    StringContent byteContent = HttpContentConverter.ConvertFromJson(jsonContent);
                    var response = httpClient.PutAsync(requsetUri, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        var dataObject = JObject.Parse(content)[property].ToString();
                        return dataObject;
                    }
                    return string.Empty;

                }
            }
            catch (Exception ex)
            {
                Logger.Log($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                return string.Empty;
            }
        }

        public bool CallDeleteOperation(string requestUri)
        {
            try
            {
                using (HttpClient httpClient = GetClient())
                {
                    var response = httpClient.DeleteAsync(requestUri).Result;
                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                return false;
            }

        }

        private HttpClient GetClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiUrl"]);
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", ConfigurationManager.AppSettings["ApiToken"]);
            return httpClient;
        }
    }
}
