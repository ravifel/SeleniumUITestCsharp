using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium_ui_test_c_sharp.BasePage;
using selenium_ui_test_c_sharp.Pages;

namespace selenium_ui_test_c_sharp.Tests
{
    [TestClass]
    public class RegisterTest : BaseClass
    {
        String email = "san.abreu1.12345678921212113a@test.com";
        public HomePage HomePage;
        public RegisterPage RegisterPage;

        [TestCategory("SmokeTest")]
        [TestMethod]
        public void VerifyRegisterFunctionalityWithValidData()
        {
            HomePage = new HomePage(driver);
            RegisterPage = new RegisterPage(driver);
            Assert.AreEqual(HomePage.GetTitle(), "Demo Web Shop");
            HomePage.ClickMethod(HomePage.registerLink);
            Assert.AreEqual(RegisterPage.GetTitle(), "Demo Web Shop. Register");
            RegisterPage.SelectGender();
            RegisterPage.EnterFirstName("San");
            RegisterPage.EnterLastName("Abreu");
            RegisterPage.EnterEmail(email);
            RegisterPage.EnterPassword("123456");
            RegisterPage.EnterPasswordConfirm("123456");
            RegisterPage.ClickRegisterBtn();
            String resultMessage = RegisterPage.GetSuccessfullMessage();
            Assert.AreEqual(resultMessage, "Your registration completed");
            bool IsTrue = RegisterPage.IsEmailAccountDisplayed(email);
            Assert.IsTrue(IsTrue);
            RegisterPage.ClickLogout();
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void VerifyAppLogoDisplayed()
        {

        }
    }
}