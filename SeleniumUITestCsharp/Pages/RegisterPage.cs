using System;
using OpenQA.Selenium;
using selenium_ui_test_c_sharp.WebDriverExtensions;

namespace selenium_ui_test_c_sharp.Pages
{
    public class RegisterPage
    {
        public static IWebDriver driver; // Instance of WebDriver

        // Create a constructor
        public RegisterPage(IWebDriver driver)
        {
            RegisterPage.driver = driver;
        }

        // Page Objects - For Web Elements
        public static readonly By SelectorGenderMale = By.Id("gender-male");
        public static readonly By FieldFirstName = By.Id("FirstName");
        public static readonly By FieldLastName = By.Id("LastName");
        public static readonly By FieldEmail = By.Id("Email");
        public static readonly By FieldPassword = By.Id("Password");
        public static readonly By FieldPasswordConfirm = By.Id("ConfirmPassword");
        public static readonly By BtnRegister = By.Id("register-button");
        public static readonly By MessageResult = By.ClassName("result");
        public static readonly By BtnLogout = By.ClassName("ico-logout");

        // Page Methods
        public string GetTitle()
        {
            return driver.Title;
        }

        public void SelectGender()
        {
            driver.Click(SelectorGenderMale);
        }

        public void EnterFirstName(String value)
        {
            driver.EnterText(FieldFirstName, value);
        }

        public void EnterLastName(String value)
        {
            driver.EnterText(FieldLastName, value);
        }

        public void EnterEmail(String value)
        {
            driver.EnterText(FieldEmail, value);

        }

        public void EnterPassword(String value)
        {
            driver.EnterText(FieldPassword, value);
        }

        public void EnterPasswordConfirm(String value)
        {
            driver.EnterText(FieldPasswordConfirm, value);
        }

        public void ClickRegisterBtn()
        {
            driver.Click(BtnRegister);
        }

        public string GetSuccessfullMessage()
        {
            return driver.getText(MessageResult);
        }

        public bool IsEmailAccountDisplayed(String email)
        {
            return driver.getEmailTextDisplayed(email);
        }

        public void ClickLogout()
        {
            driver.Click(BtnLogout);
        }
    }
}