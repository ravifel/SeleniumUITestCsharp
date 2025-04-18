﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUITestCsharp.BasePage;
using SeleniumUITestCsharp.Pages;

namespace SeleniumUITestCsharp.Tests
{
    [TestClass]
    public class RegisterTest : BaseClass
    {
        String email = "user.test.1234@test.com";
        public HomePage HomePage;
        public RegisterPage RegisterPage;

        [TestMethod]
        [TestCategory("Validation of new user registration tests.")]
        [Description("Success")]
        public void RegistrationTestSuccessful()
        {
            HomePage = new HomePage(driver);
            RegisterPage = new RegisterPage(driver);
            Assert.AreEqual(HomePage.GetTitle(), "Demo Web Shop");
            HomePage.ClickMethod(HomePage.registerLink);
            Assert.AreEqual(RegisterPage.GetTitle(), "Demo Web Shop. Register");
            RegisterPage.SelectMethod(RegisterPage.SelectorGenderMale);
            RegisterPage.FillTextInput(RegisterPage.FieldFirstName, "Dom");
            RegisterPage.FillTextInput(RegisterPage.FieldLastName, "Silva");
            RegisterPage.FillTextInput(RegisterPage.FieldEmail, email);
            RegisterPage.FillTextInput(RegisterPage.FieldPassword, "123456");
            RegisterPage.FillTextInput(RegisterPage.FieldPasswordConfirm, "123456");
            RegisterPage.ClickMethod(RegisterPage.BtnRegister);
            String resultMessage = RegisterPage.GetSuccessfullMessage();
            Assert.AreEqual(resultMessage, "Your registration completed");
            bool IsTrue = RegisterPage.IsEmailAccountDisplayed(email);
            Assert.IsTrue(IsTrue);
            RegisterPage.ClickMethod(RegisterPage.BtnLogout);
        }
    }
}