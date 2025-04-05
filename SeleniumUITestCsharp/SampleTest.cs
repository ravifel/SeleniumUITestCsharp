using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_ui_test_c_sharp
{
    [TestClass]
    public class SampleTest
    {
        String email = "dan.silva47323232323235555@example.com";
        IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver(); // Create an instance for Webdriver.
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/"); // Navigate to ste URL.
            driver.Manage().Window.Maximize(); // Maximize the Browser Window.
        }

        [TestCategory("SampleTest")]
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                String title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");

                driver.FindElement(By.ClassName("ico-register")).Click(); // Click on Register Link
                String registerTitle = driver.Title;
                Assert.AreEqual(registerTitle, "Demo Web Shop. Register");

                driver.FindElement(By.Id("gender-male")).Click(); // Select the Male Gender
                driver.FindElement(By.Id("FirstName")).SendKeys("Dan"); // Enter First Name
                driver.FindElement(By.Id("LastName")).SendKeys("Silva"); // Enter Last Name
                driver.FindElement(By.Id("Email")).SendKeys(email); // Enter Email
                driver.FindElement(By.Id("Password")).SendKeys("123456"); // Enter Password
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("123456"); // Enter Confirm Password
                driver.FindElement(By.Id("register-button")).Click(); // Click on Register button

                String message = driver.FindElement(By.ClassName("result")).Text;// Get the successfull Test Message
                Assert.AreEqual(message, "Your registration completed");

                IWebElement emailAccount = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
                Assert.IsTrue(emailAccount.Displayed);

                driver.FindElement(By.ClassName("ico-logout")).Click(); // Log out
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}