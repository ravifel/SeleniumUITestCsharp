using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumUITestCsharp.BasePage;
using SeleniumUITestCsharp.DataModel;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SeleniumUITestCsharp
{
    [TestClass]
    public class ReadJsonData : BaseClass
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [TestCategory("Read Json Data Test")]
        public void ReadJsonDataTest()
        {
            string readDataFromJson = File.ReadAllText(@"C:\Users\ravif\source\repos\SeleniumUITestCsharp\SeleniumUITestCsharp\TestData\userdata.json");
            var registerData = JsonSerializer.Deserialize<RegisterDataModel>(readDataFromJson);
            Console.WriteLine(registerData.FirstName);
            Console.WriteLine(registerData.LastName);
            Console.WriteLine(registerData.Email);
            Console.WriteLine(registerData.Password);
            String title = driver.Title;
            Assert.AreEqual(title, "Demo Web Shop");
            driver.FindElement(By.ClassName("ico-register")).Click();
            String registerTitle = driver.Title;
            Assert.AreEqual(registerTitle, "Demo Web Shop. Register");
            driver.FindElement(By.Id("gender-male")).Click();
            driver.FindElement(By.Id("FirstName")).SendKeys(registerData.FirstName);
            driver.FindElement(By.Id("LastName")).SendKeys(registerData.LastName);
            driver.FindElement(By.Id("Email")).SendKeys(registerData.Email);
            driver.FindElement(By.Id("Password")).SendKeys(registerData.Password);
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys(registerData.Password);
            driver.FindElement(By.Id("register-button")).Click();
        }
    }
}