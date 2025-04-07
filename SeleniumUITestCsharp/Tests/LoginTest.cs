using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUITestCsharp.BasePage;
using SeleniumUITestCsharp.Pages;
using System.Configuration;

namespace SeleniumUITestCsharp.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    { 
        HomePage HomePage;
        LoginPage LoginPage;

        [TestMethod]
        [TestCategory("Smoke Test")]
        public void VerifyLoginFunctionalityWithValidData()
        {
            HomePage = new HomePage(driver);
            LoginPage = new LoginPage(driver);
            string username = ConfigurationManager.AppSettings["Email"];
            string password = ConfigurationManager.AppSettings["Password"];
            HomePage.ClickMethod(HomePage.loginLink);
            string title = LoginPage.GetTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            LoginPage.FillTextInput(LoginPage.FieldEmail, username);
            LoginPage.FillTextInput(LoginPage.FieldPassword, password);
            LoginPage.ClickMethod(LoginPage.BtnLogin);
        }
    }
}