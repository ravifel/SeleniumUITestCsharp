using OpenQA.Selenium;
using SeleniumUITestCsharp.WebDriverExtensions;

namespace SeleniumUITestCsharp.Pages
{
    public class LoginPage
    {
        public static IWebDriver driver; // Instance of WebDriver

        // Create a constructor
        public LoginPage(IWebDriver driver)
        {
            LoginPage.driver = driver;
        }

        // Page objects
        public static readonly By FieldEmail = By.Id("Email");
        public static readonly By FieldPassword = By.Id("Password");
        public static readonly By BtnLogin = By.CssSelector("input.button-1.login-button");

        // Page Methods
        public string GetTitle()
        {
            return driver.Title;
        }

        public void FillTextInput(By component, string value)
        {
            driver.EnterText(component, value);
        }

        public void ClickMethod(By component)
        {
            driver.Click(component);
        }
    }
}