using EmployeeManager.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace UnitTests
{
    [TestClass]
    public class WebApiCallerTests
    {
        [TestMethod]
        public void CallGetOperation_ReturnsEmployeesString_WithValidApi()
        {
            //Arrange
            AddApiUrl();
            WebApiCaller webApiCaller = new WebApiCaller();

            //Act
            var employees = webApiCaller.CallGetOperation("users");
            //Assert
            Assert.IsFalse(string.IsNullOrWhiteSpace(employees));

        }
        [TestMethod]
        public void CallGetOperation_ReturnsEmptyString_WithInValidApi()
        {
            //Arrange
            RemoveApiUrl();
            WebApiCaller webApiCaller = new WebApiCaller();

            //Act
            var employees = webApiCaller.CallGetOperation("users");
            //Assert
            Assert.IsTrue(string.IsNullOrWhiteSpace(employees));

        }

        //todo tests for modification methods(add, update, delete) will be implemented when test api is provided.

        #region helpers
        private void RemoveApiUrl()
        {
            var configSettings = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configSettings.AppSettings.Settings;
            if (settings["ApiUrl"] != null)
            {
                settings.Remove("ApiUrl");
            }

            configSettings.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void AddApiUrl()
        {
            var configSettings = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configSettings.AppSettings.Settings;
            if (settings["ApiUrl"] == null)
            {
                settings.Add("ApiUrl", "https://gorest.co.in/public-api/");
            }

            configSettings.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }
        #endregion
    }
}
