using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTestProject.PageObject
{
    internal class SignUpPage
    { 
        public SignUpPage()
        {
            driver = Utilities.Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));








        public void EnterUsername()
        {
            username.SendKeys("lurtz23");
        }

        public void EnterEmail()
        {
            email.SendKeys("sarpbakis@gmail.com");
        }

        public void EnterPassword()
        {
            password.SendKeys("Lebronbest.23");
        }

        public void ClickSignUpButton()
        {
            signUp.Click();
        }

        public void NavigateToWebSite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/register");
        }
    }
}
