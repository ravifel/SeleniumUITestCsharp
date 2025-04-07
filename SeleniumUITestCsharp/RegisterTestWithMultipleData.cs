using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using SeleniumUITestCsharp.BasePage;
using SeleniumUITestCsharp.DataModel;

namespace SeleniumUITestCsharp
{
    [TestClass]
    public class RegisterTestWithMultipleData : BaseClass
    {
        [TestMethod]
        public void ReadJsonDataMultipleObjects()
        {
            RegisterList userdata = JsonConvert.DeserializeObject<RegisterList>(File.ReadAllText(@"C:\\Users\\ravif\\source\\repos\\SeleniumUITestCsharp\\SeleniumUITestCsharp\\TestData\\registerdata.json"));

            for (int i = 0; i < userdata.Register.Count; i++)
            {
                string firstName = userdata.Register[i].FirstName.ToString();
                string lastName = userdata.Register[i].LastName.ToString();
                string email = userdata.Register[i].Email.ToString();
                string password = userdata.Register[i].Password.ToString();
                driver.FindElement(By.ClassName("ico-register")).Click();
                String registerTitle = driver.Title;
                Assert.AreEqual(registerTitle, "Demo Web Shop. Register");
                driver.FindElement(By.Id("gender-male")).Click();
                driver.FindElement(By.Id("FirstName")).SendKeys(firstName);
                driver.FindElement(By.Id("LastName")).SendKeys(lastName);
                driver.FindElement(By.Id("Email")).SendKeys(email);
                driver.FindElement(By.Id("Password")).SendKeys(password);
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys(password);
                driver.FindElement(By.Id("register-button")).Click();
                String message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");
                driver.FindElement(By.ClassName("ico-logout")).Click();
            }
        }
    }
}