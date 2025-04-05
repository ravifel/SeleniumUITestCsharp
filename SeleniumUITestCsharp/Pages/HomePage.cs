﻿using OpenQA.Selenium;
using selenium_ui_test_c_sharp.WebDriverExtensions;

namespace selenium_ui_test_c_sharp.Pages
{
    public class HomePage
    {
        public static IWebDriver driver; // Instance of WebDriver

        // Create a constructor
        public HomePage(IWebDriver driver)
        {
            HomePage.driver = driver;
        }

        // Page objects - For Web Elements
        public static readonly By registerLink = By.ClassName("ico-register");
        public static readonly By loginLink = By.ClassName("ico-login");

        // Page Methods
        public string GetTitle()
        {
            return driver.Title;
        }

        public void ClickMethod(By component)
        {
            driver.Click(component);
        }
    }
}