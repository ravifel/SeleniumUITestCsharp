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

        public void SelectMethod(By component)
        {
            driver.Click(component);
        }

        public void FillTextInput(By component, string value)
        {
            driver.EnterText(component, value);
        }

        public void ClickMethod(By component)
        {
            driver.Click(component);
        }

        public string GetSuccessfullMessage()
        {
            return driver.getText(MessageResult);
        }

        public bool IsEmailAccountDisplayed(String email)
        {
            return driver.getEmailTextDisplayed(email);
        }
    }
}