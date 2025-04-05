using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium_ui_test_c_sharp.BasePage;
using selenium_ui_test_c_sharp.Pages;
using System.Configuration;

namespace selenium_ui_test_c_sharp.Tests
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