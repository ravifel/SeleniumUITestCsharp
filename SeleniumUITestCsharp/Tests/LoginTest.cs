using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium_ui_test_c_sharp.BasePage;
using selenium_ui_test_c_sharp.Pages;
using System.Configuration;

namespace selenium_ui_test_c_sharp.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    { 
        HomePage homePage;
        LoginPage loginPage;

        [TestMethod]
        [TestCategory("Smoke Test")]
        public void VerifyLoginFunctionalityWithValidData()
        {
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);

            string username = ConfigurationManager.AppSettings["Email"];
            string password = ConfigurationManager.AppSettings["Password"];

            homePage.ClickLoginLink();
            string title = loginPage.GetTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAdress(username);
            loginPage.EnterPassword(password);
            loginPage.ClickLoginButton();
        }
    }
}